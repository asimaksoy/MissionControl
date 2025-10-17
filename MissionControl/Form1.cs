using MissionControl.Data;
using MissionControl.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class Form1 : Form
    {
        public string filePath = "../../Works.txt";
        public string btnType;
        public string[,] allDataArray;

        public Form1()
        {
            InitializeComponent();
        }


        /* public string[,] ApplyFilters()
         {

         }*/

        public void RefreshWorkItemListBoxes()
        {
            string status;
            pnlToDo.Controls.Clear();
            pnlInProgress.Controls.Clear();
            pnlDone.Controls.Clear();
            int statusdizilinecount = 0;
            int statusdizicolumncount = allDataArray.GetLength(1);

            foreach (var item in Enum.GetValues(typeof(WorkItem.Statuses)))
            {
                status = item.ToString();
                for (int i = 0; i < allDataArray.GetLength(0); i++)
                {
                    if (allDataArray[i, 8] == status)
                    { statusdizilinecount++; }

                }

                string[,] listdizi = new string[statusdizilinecount, statusdizicolumncount];
                int yenidizisatir = 0;
                int position = 0;
                for (int i = 0; i < allDataArray.GetLength(0); i++)
                {
                    Button btnWork = new Button();
                    //Tanımladığım mousedown methodunu oluşan her butonun mousedown olayına ekliyorum
                    btnWork.MouseDown += Btn_MouseDown;
                    btnWork.Tag = i;
                    if (allDataArray[i, 8] == status)
                    {
                        for (int j = 0; j < allDataArray.GetLength(1); j++)
                        {
                            listdizi[yenidizisatir, j] = allDataArray[i, j];

                        }

                        string id = listdizi[yenidizisatir, 0];
                        string name = listdizi[yenidizisatir, 2];
                        name = name.Length <= 30 ? name : name.Substring(0, 30);
                        btnWork.Location = new Point(0, (30 * position) + 1);
                        switch ((WorkItem.Statuses)item)
                        {
                            case WorkItem.Statuses.ToDo:
                                pnlToDo.Controls.Add(btnWork);

                                btnWork.Width = pnlToDo.Width;
                                btnWork.Text = $"{id} - {name}";
                                break;
                            case WorkItem.Statuses.InProgress:
                                pnlInProgress.Controls.Add(btnWork);
                                btnWork.Width = pnlInProgress.Width;
                                btnWork.Text = $"{id} - {name}";
                                break;
                            case WorkItem.Statuses.Done:
                                pnlDone.Controls.Add(btnWork);
                                btnWork.Width = pnlDone.Width;
                                btnWork.Text = $"{id} - {name}";
                                break;
                            default:
                                break;
                        }
                        ++position;
                        ++yenidizisatir;
                    }
                }
            }
        }

        public void ChangeStatus(WorkItem.Statuses newstatus, int selectid)
        {
            allDataArray[selectid, allDataArray.GetLength(1) - 1] = newstatus.ToString();
            Repository.SaveAllDataToFile(false);
            RefreshWorkItemListBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddandUpdate addandUpdatefrm = new AddandUpdate();
            addandUpdatefrm.isAddForm = true;
            addandUpdatefrm.Text = "Add Form";
            addandUpdatefrm.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allDataArray = Repository.LoadAllDataFromFile(filePath);
            RefreshWorkItemListBoxes();
        }


        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            //Mousen sol butonu ile basınca butonun taşıma işlemini tanımlıyorum.
            if (e.Button == MouseButtons.Left)
            {
                Button btn = sender as Button;
                DoDragDrop(btn, DragDropEffects.Move);
            }
        }






        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        public int GetIdFromSelectedList(ListBox selectedList)
        {
            int.TryParse(selectedList.SelectedItem.ToString().Split('-')[0], out int id);
            return id;
        }

        private void btnDetailsClick(object sender, EventArgs e)
        {
            int selectedId = -1;
            AddandUpdate addandUpdatefrm = new AddandUpdate();

            if (selectedId != -1)
            {
                int.TryParse(allDataArray[selectedId - 1, 0], out selectedId);
                addandUpdatefrm.detailId = selectedId;
                addandUpdatefrm.isAddForm = false;
                addandUpdatefrm.Text = "Update Form";
                addandUpdatefrm.lblEstimatEffort.Visible = true;
                addandUpdatefrm.txtEstimateEffort.Visible = true;
                addandUpdatefrm.Show();
                Hide();
            }
        }

        //panele taşıma işlemini başlat. Panellerin DragEnter olayına bu methodu yaz
        private void pnl_DragEnter(object sender, DragEventArgs e)
        {
            //Sürüklenerek Gelen veri nesnesi(e.Data) bir butonmu (GetDataPresent(typeof(Button)))
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                //eğer öyleyse veri nesnesine taşıma efekti ver
                e.Effect = DragDropEffects.Move;
            }
        }

        //panele sürükle bırak işlemini bitirme metodu panellerin DragDrop Olaylarına Bu methodu yaz
        private void pnl_DragDrop(object sender, DragEventArgs e)
        {
            int id = -1;
            WorkItem.Statuses newStatus;
            //buton oluştur ve içine e ile gelen veri nesnesini at
            Button btn = (Button)e.Data.GetData(typeof(Button));
            //Butonun taşınacağı panel
            Panel destinationPanel = (Panel)sender;
            int.TryParse(btn.Tag.ToString(), out id);
            //Taşınan panele göre yeni durum değişkene at
            if (destinationPanel.Name == "pnlToDo")
            {
                newStatus = WorkItem.Statuses.ToDo;
            }
            else if (destinationPanel.Name == "pnlInProgress")
            {
                newStatus = WorkItem.Statuses.InProgress;
            }
            else
            {
                newStatus = WorkItem.Statuses.Done;
            }
            //ChangeStatus methodunu çağırarak panelleri düzenle ve yenile
            ChangeStatus(newStatus, id);
            MessageBox.Show("Taşıma İşlemi Tammlandı");
        }
    }
}
