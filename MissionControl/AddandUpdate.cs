using MissionControl.Data;
using MissionControl.Domain;
using System;
using System.IO;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class AddandUpdate : Form
    {
        public bool isAddForm;
        public string filePath = "../../Works.txt";
        WorkItem.WorkTypes selectedWorkType;
        Bug.Severities selectSeverity;
        WorkItem.Statuses selectStatus;
        public int detailId;
        public string detailtype;
        public string detailseverity;
        public string estimateeffort;
        public string detailStatus;

        public AddandUpdate()
        {
            InitializeComponent();
        }

        public int StringIntConvert(string str)
        {
            int.TryParse(str, out int number);
                return number;
        }

        private void AddandUpdate_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = Enum.GetValues(typeof(WorkItem.WorkTypes));
            cbxStatusses.DataSource = Enum.GetValues(typeof(WorkItem.Statuses));
            cbxSeverity.DataSource = Enum.GetValues(typeof(Bug.Severities));
            string[,] fileDataRead = Repository.LoadAllDataFromFile(filePath);

            if (isAddForm)
            {
                btnSave.Text = "Save";
            }
            else
            {
                detailStatus = fileDataRead[detailId - 1, 8];
                detailtype = fileDataRead[detailId-1, 1];
                detailseverity = fileDataRead[detailId - 1, 4];

                cbxStatusses.SelectedIndex =
                    detailStatus == "ToDo" ? 0 : detailStatus == "InProgress" ? 1 : detailStatus == "Done" ? 2 : 3;

                cbxType.SelectedIndex = detailtype == "Task" ? 0 : detailtype == "Bug" ? 1 : 2;
                if (detailtype == "Bug")
                {
                    cbxSeverity.SelectedIndex = detailseverity == "Minor" ? 0 : detailseverity == "Major" ? 1 : 2;
                }
                else
                {
                    txtTaskFeatureRating.Text = detailseverity;
                }

                txtName.Text = fileDataRead[detailId - 1, 2];
                txtDescription.Text = fileDataRead[detailId - 1, 3];
                txtEstimateEffort.Text = fileDataRead[detailId - 1, 5];
                btnSave.Text = "Save";
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cbxType.SelectedIndex.ToString(), out selectedWorkType);
            if (selectedWorkType == WorkItem.WorkTypes.Task)
            {
                cbxSeverity.Visible = false;
                label4.Text = "SubTask Count";
                txtTaskFeatureRating.Visible = true;
            }
            else if (selectedWorkType == WorkItem.WorkTypes.Bug)
            {
                txtTaskFeatureRating.Visible = false;
                cbxSeverity.DataSource = Enum.GetValues(typeof(Bug.Severities));
                cbxSeverity.Visible = true;
                label4.Text = "Severity";
            }
            else if (selectedWorkType == WorkItem.WorkTypes.Feature)
            {
                cbxSeverity.Visible = false;
                txtTaskFeatureRating.Visible = true;
                label4.Text = "Story Point";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data="";
            if (isAddForm)
            {
                Text = "Add Form";
                if (selectedWorkType == WorkItem.WorkTypes.Task)
                {
                    Enum.TryParse(cbxStatusses.SelectedIndex.ToString(), out selectStatus);
                    Task task = new Task(txtName.Text, txtDescription.Text, StringIntConvert(txtTaskFeatureRating.Text));
                    data = $"{task.Id.ToString()},Task,{task.Name},{task.Description},{task.SubTaskCount.ToString()},{task.EstimateEffort()},{task.CreatedBy},{task.CreatedDate},{selectStatus}";
                }
                if (selectedWorkType == WorkItem.WorkTypes.Bug)
                {
                    Enum.TryParse(cbxStatusses.SelectedIndex.ToString(), out selectStatus);
                    Enum.TryParse(cbxSeverity.SelectedIndex.ToString(), out selectSeverity);
                    Bug bug = new Bug(txtName.Text, txtDescription.Text, selectSeverity);
                    data = $"{bug.Id.ToString()},Bug,{bug.Name},{bug.Description},{bug.Severity.ToString()},{bug.EstimateEffort()},{bug.CreatedBy},{bug.CreatedDate},{selectStatus}";
                   
                }
                if (selectedWorkType == WorkItem.WorkTypes.Feature)
                {
                    Enum.TryParse(cbxStatusses.SelectedIndex.ToString(), out selectStatus);
                    Feature feature = new Feature(txtName.Text, txtDescription.Text, StringIntConvert(txtTaskFeatureRating.Text));
                    data = $"{feature.Id.ToString()},Feature,{feature.Name},{feature.Description},{feature.StoryPoint.ToString()},{feature.EstimateEffort()},{feature.CreatedBy},{feature.CreatedDate},{selectStatus}";

                }
                //Environmen.NewLine => veri eklenince yeni satırdan devam etmesini sağlıyor.
                File.AppendAllText(filePath, data + Environment.NewLine);
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
            if (!isAddForm)
            {
                Text = "Update Form";
                Form1 form1 = new Form1();
                string[,] fileDizi = Repository.LoadAllDataFromFile(filePath);
                Enum.TryParse(cbxStatusses.SelectedIndex.ToString(), out selectStatus);
                if (selectedWorkType == WorkItem.WorkTypes.Task)
                {
                    Task task = new Task(txtName.Text, txtDescription.Text, StringIntConvert(txtTaskFeatureRating.Text));
                    fileDizi[detailId - 1, 1] = selectedWorkType.ToString();
                    fileDizi[detailId - 1, 2] = task.Name;
                    fileDizi[detailId - 1, 3] = task.Description;
                    fileDizi[detailId - 1, 4] = task.SubTaskCount.ToString();
                    fileDizi[detailId - 1, 5] = task.EstimateEffort().ToString();
                    fileDizi[detailId - 1, 8] = selectStatus.ToString();
                }                            
                if (selectedWorkType == WorkItem.WorkTypes.Bug)
                {
                    
                    Enum.TryParse(cbxSeverity.SelectedIndex.ToString(), out selectSeverity);
                    Bug bug = new Bug(txtName.Text, txtDescription.Text, selectSeverity);
                    fileDizi[detailId - 1, 1] = selectedWorkType.ToString();
                    fileDizi[detailId - 1, 2] = bug.Name;
                    fileDizi[detailId - 1, 3] = bug.Description;
                    fileDizi[detailId - 1, 4] = bug.Severity.ToString();
                    fileDizi[detailId - 1, 5] = bug.EstimateEffort().ToString();
                    fileDizi[detailId - 1, 8] = selectStatus.ToString();
                }
                if (selectedWorkType == WorkItem.WorkTypes.Feature)
                {
                    Feature feature = new Feature(txtName.Text, txtDescription.Text, StringIntConvert(txtTaskFeatureRating.Text));
                    fileDizi[detailId - 1, 1] = selectedWorkType.ToString();
                    fileDizi[detailId - 1, 2] = feature.Name;
                    fileDizi[detailId - 1, 3] = feature.Description;
                    fileDizi[detailId - 1, 4] = feature.StoryPoint.ToString();
                    fileDizi[detailId - 1, 5] = feature.EstimateEffort().ToString();
                    fileDizi[detailId - 1, 8] = selectStatus.ToString();
                }
                string[] row = new string[fileDizi.GetLength(0)];
                for (int i = 0; i < fileDizi.GetLength(0); i++)
                {
                    for (int j = 0; j < fileDizi.GetLength(1); j++)
                    {
                        row[i] += fileDizi[i, j].ToString();
                        if (j < (fileDizi.GetLength(1) - 1))
                        {
                            row[i] += ",";
                        }
                    }
                }
                File.WriteAllLines(filePath, row);
                form1.Show();
                Hide();
            }
        }

        private void lstBackList_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
