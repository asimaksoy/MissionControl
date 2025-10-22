using MissionControl.Data;
using MissionControl.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionControl
{
    public partial class Form1 : Form
    {
        public string btnType;
        public string[,] allDataArray;
        public int selectItemId;
        public Form1()
        {
            InitializeComponent();
        }


        //public void ApplyFilters()
        //{
        //    string[,] filterDizi = new string[allDataArray.GetLength(0),allDataArray.GetLength(1)];
        //    int newDiziIndex = 0;
        //    for (int i = 0; i < allDataArray.GetLength(0); i++)
        //    {
        //        if (cbxType.SelectedItem.ToString() != "AllType" && allDataArray[i, 1] == cbxType.SelectedItem.ToString())
        //        {
        //            if (txtName.Text != null && allDataArray[i, 2] == txtName.Text)
        //            {
        //                if (Convert.ToDateTime(allDataArray[i, 7]) >= datetimeStart.Value &&
        //                    Convert.ToDateTime(allDataArray[i, 7]) <= datetimeEnd.Value)
        //                {
        //                    filterDizi[newDiziIndex, 0] = allDataArray[i, 0];
        //                    filterDizi[newDiziIndex, 1] = allDataArray[i, 1];
        //                    filterDizi[newDiziIndex, 2] = allDataArray[i, 2];
        //                    filterDizi[newDiziIndex, 3] = allDataArray[i, 3];
        //                    filterDizi[newDiziIndex, 4] = allDataArray[i, 4];
        //                    filterDizi[newDiziIndex, 5] = allDataArray[i, 5];
        //                    filterDizi[newDiziIndex, 6] = allDataArray[i, 6];
        //                    filterDizi[newDiziIndex, 7] = allDataArray[i, 7];
        //                    filterDizi[newDiziIndex, 8] = allDataArray[i, 8];
        //                }
        //            }
        //            else
        //            {
        //                if (Convert.ToDateTime(allDataArray[i, 7]) >= datetimeStart.Value &&
        //                    Convert.ToDateTime(allDataArray[i, 7]) <= datetimeEnd.Value)
        //                {
        //                    filterDizi[newDiziIndex, 0] = allDataArray[i, 0];
        //                    filterDizi[newDiziIndex, 1] = allDataArray[i, 1];
        //                    filterDizi[newDiziIndex, 2] = allDataArray[i, 2];
        //                    filterDizi[newDiziIndex, 3] = allDataArray[i, 3];
        //                    filterDizi[newDiziIndex, 4] = allDataArray[i, 4];
        //                    filterDizi[newDiziIndex, 5] = allDataArray[i, 5];
        //                    filterDizi[newDiziIndex, 6] = allDataArray[i, 6];
        //                    filterDizi[newDiziIndex, 7] = allDataArray[i, 7];
        //                    filterDizi[newDiziIndex, 8] = allDataArray[i, 8];
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (txtName.Text != null && allDataArray[i, 2] == txtName.Text)
        //            {
        //                if (Convert.ToDateTime(allDataArray[i, 7]) >= datetimeStart.Value &&
        //                    Convert.ToDateTime(allDataArray[i, 7]) <= datetimeEnd.Value)
        //                {
        //                    filterDizi[newDiziIndex, 0] = allDataArray[i, 0];
        //                    filterDizi[newDiziIndex, 1] = allDataArray[i, 1];
        //                    filterDizi[newDiziIndex, 2] = allDataArray[i, 2];
        //                    filterDizi[newDiziIndex, 3] = allDataArray[i, 3];
        //                    filterDizi[newDiziIndex, 4] = allDataArray[i, 4];
        //                    filterDizi[newDiziIndex, 5] = allDataArray[i, 5];
        //                    filterDizi[newDiziIndex, 6] = allDataArray[i, 6];
        //                    filterDizi[newDiziIndex, 7] = allDataArray[i, 7];
        //                    filterDizi[newDiziIndex, 8] = allDataArray[i, 8];
        //                }
        //            }
        //            else
        //            {
        //                if (Convert.ToDateTime(allDataArray[i, 7]) >= datetimeStart.Value &&
        //                    Convert.ToDateTime(allDataArray[i, 7]) <= datetimeEnd.Value)
        //                {
        //                    filterDizi[newDiziIndex, 0] = allDataArray[i, 0];
        //                    filterDizi[newDiziIndex, 1] = allDataArray[i, 1];
        //                    filterDizi[newDiziIndex, 2] = allDataArray[i, 2];
        //                    filterDizi[newDiziIndex, 3] = allDataArray[i, 3];
        //                    filterDizi[newDiziIndex, 4] = allDataArray[i, 4];
        //                    filterDizi[newDiziIndex, 5] = allDataArray[i, 5];
        //                    filterDizi[newDiziIndex, 6] = allDataArray[i, 6];
        //                    filterDizi[newDiziIndex, 7] = allDataArray[i, 7];
        //                    filterDizi[newDiziIndex, 8] = allDataArray[i, 8];
        //                }
        //            }
        //        }
        //        ++newDiziIndex;
        //    }
        //    allDataArray = filterDizi;
        //    RefreshWorkItemListBoxes();
        //}

        public void ApplyFilters()
        {
            allDataArray=Repository.LoadAllDataFromFile();
            // Basit yerel değişkenler
            int rowCount = allDataArray.GetLength(0);
            int colCount = allDataArray.GetLength(1);

            string selectedType = (cbxType.SelectedItem == null)
                ? "AllType"
                : cbxType.SelectedItem.ToString();

            bool filterByType = selectedType != "AllType";

            string nameFilter = txtName.Text;
            bool filterByName = !string.IsNullOrWhiteSpace(nameFilter);

            DateTime start = datetimeStart.Value;
            DateTime end = datetimeEnd.Value;

            // 1. GEÇİŞ: Kaç satır eşleşiyor?
            int matchCount = 0;
            for (int i = 0; i < rowCount; i++)
            {
                if (RowMatches(i, filterByType, selectedType, filterByName, nameFilter, start, end))
                    matchCount++;
            }

            // 2. GEÇİŞ: Sadece eşleşenleri yeni diziye kopyala
            string[,] filtered = new string[matchCount, colCount];
            int newIndex = 0;

            for (int i = 0; i < rowCount; i++)
            {
                if (RowMatches(i, filterByType, selectedType, filterByName, nameFilter, start, end))
                {
                    // satırı kopyala
                    for (int c = 0; c < colCount; c++)
                        filtered[newIndex, c] = allDataArray[i, c];

                    newIndex++; // sadece kopyalayınca artır
                }
            }

            // Sonucu ata ve listeyi yenile
            allDataArray = filtered;
            RefreshWorkItemListBoxes();

            // --- Yerel yardımcı metodlar (ileri konu yok, sadece basit if ve TryParse) ---
            bool RowMatches(int i, bool byType, string type, bool byName, string name, DateTime s, DateTime e)
            {
                // Type filtresi
                if (byType && allDataArray[i, 1] != type)
                    return false;

                // Name filtresi
                if (byName && !allDataArray[i, 2].Contains(name))
                    return false;

                // Tarih filtresi (kolon 7)
                if (!DateTime.TryParse(allDataArray[i, 7], out DateTime rowDate))
                    return true; // tarih okunamıyorsa bu satırı alma (istersen true da yapabilirsin)

                if (rowDate <= s || rowDate >= e)
                    return false;

                return true;
            }
        }


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
                    btnWork.Height = 50;
                    btnWork.ContextMenuStrip = cntxtRightClickMenu;
                    //Tanımladığım mousedown methodunu oluşan her butonun mousedown olayına ekliyorum
                    btnWork.MouseDown += Btn_MouseDown;
                    btnWork.Tag = i;
                    if (allDataArray[i, 8] == status)
                    {
                        btnWork.BackColor = allDataArray[i, 1] == "Bug" ? Color.Red : allDataArray[i, 1] == "Feature" ? Color.Green : Color.White;
                        btnWork.ForeColor = allDataArray[i, 1] == "Bug" ? Color.White : allDataArray[i, 1] == "Feature" ? Color.White : Color.Black;
                        for (int j = 0; j < allDataArray.GetLength(1); j++)
                        {
                            listdizi[yenidizisatir, j] = allDataArray[i, j];

                        }

                        string id = listdizi[yenidizisatir, 0];
                        string name = listdizi[yenidizisatir, 2];
                        name = name.Length <= 30 ? name : name.Substring(0, 30);
                        btnWork.Location = new Point(0, (55 * position) + 1);
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
            addandUpdatefrm.isDetailForm = false;
            addandUpdatefrm.Text = "Add Form";
            addandUpdatefrm.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allDataArray = Repository.LoadAllDataFromFile();
            datetimeStart.Value = DateTime.Now.AddDays(-14);
            datetimeEnd.Value = DateTime.Now;
            cbxType.Items.Add("AllType");
            cbxType.SelectedIndex = 0;
            foreach (var item in Enum.GetValues(typeof(WorkItem.WorkTypes)))
            {
                cbxType.Items.Add(item.ToString());
            }
            RefreshWorkItemListBoxes();
        }


        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            //Mousen sol butonu ile basınca butonun taşıma işlemini tanımlıyorum.
            if (e.Button == MouseButtons.Left)
            {
                Button btn = sender as Button;
                DoDragDrop(btn, DragDropEffects.Move);
                selectItemId = (int)btn.Tag;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnArchive.Enabled = true;
                btnDetails.Enabled = true;
                btnEdit.Enabled = true;
                if (allDataArray[selectItemId, 8] == "Done")
                {
                    btnNext.Enabled = false;
                }
                else if (allDataArray[selectItemId, 8] == "ToDo")
                {
                    btnPrev.Enabled = false;
                }
            }
        }






        private void btnNext_Click(object sender, EventArgs e)
        {
            if (allDataArray[selectItemId, 8] == "ToDo")
            {
                ChangeStatus(WorkItem.Statuses.InProgress, selectItemId);
            }
            else if (allDataArray[selectItemId, 8] == "InProgress")
            {
                ChangeStatus(WorkItem.Statuses.Done, selectItemId);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (allDataArray[selectItemId, 8] == "InProgress")
            {
                ChangeStatus(WorkItem.Statuses.ToDo, selectItemId);
            }
            else if (allDataArray[selectItemId, 8] == "Done")
            {
                ChangeStatus(WorkItem.Statuses.InProgress, selectItemId);
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ChangeStatus(WorkItem.Statuses.Archived, selectItemId);
        }

        public int GetIdFromSelectedList(ListBox selectedList)
        {
            int.TryParse(selectedList.SelectedItem.ToString().Split('-')[0], out int id);
            return id;
        }
        public void DetailOrEdit(bool isDetail)
        {
            AddandUpdate addandUpdatefrm = new AddandUpdate();

            if (selectItemId != -1)
            {
                int.TryParse(allDataArray[selectItemId - 1, 0], out selectItemId);
                addandUpdatefrm.detailId = selectItemId;
                addandUpdatefrm.isAddForm = false;
                addandUpdatefrm.isDetailForm = isDetail;
                addandUpdatefrm.Text = "Update Form";
                addandUpdatefrm.lblEstimatEffort.Visible = true;
                addandUpdatefrm.txtEstimateEffort.Visible = true;
                addandUpdatefrm.Show();
                Hide();
            }
        }
        private void btnDetailsClick(object sender, EventArgs e)
        {
            DetailOrEdit(true);
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

        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pnl = cntxtRightClickMenu.SourceControl.Parent.Name;
            int.TryParse(cntxtRightClickMenu.SourceControl.Tag.ToString(), out int id);
            if (pnl == "pnlInProgress")
            {
                ChangeStatus(WorkItem.Statuses.ToDo, id);
            }
            else if (pnl == "pnlDone")
            {
                ChangeStatus(WorkItem.Statuses.InProgress, id);
            }

        }


        private void cntxtRightClickMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pnl = cntxtRightClickMenu.SourceControl.Parent.Name;
            if (pnl == "pnlToDo")
            {
                cntxtRightClickMenu.Items[0].Enabled = false;
                cntxtRightClickMenu.Items[1].Enabled = true;
            }
            else if (pnl == "pnlInProgress")
            {
                cntxtRightClickMenu.Items[0].Enabled = true;
                cntxtRightClickMenu.Items[1].Enabled = true;
            }
            else if (pnl == "pnlDone")
            {
                cntxtRightClickMenu.Items[0].Enabled = true;
                cntxtRightClickMenu.Items[1].Enabled = false;
            }
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pnl = cntxtRightClickMenu.SourceControl.Parent.Name;
            int.TryParse(cntxtRightClickMenu.SourceControl.Tag.ToString(), out int id);
            if (pnl == "pnlToDo")
            {
                ChangeStatus(WorkItem.Statuses.InProgress, id);
            }
            else if (pnl == "pnlInProgress")
            {
                ChangeStatus(WorkItem.Statuses.Done, id);
            }
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(cntxtRightClickMenu.SourceControl.Tag.ToString(), out int id);
            ChangeStatus(WorkItem.Statuses.Archived, id);
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(cntxtRightClickMenu.SourceControl.Tag.ToString(), out int selectedId);
            DetailOrEdit(true);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(cntxtRightClickMenu.SourceControl.Tag.ToString(), out int selectedId);
            DetailOrEdit(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DetailOrEdit(false);
        }


        private void ApplyFilterOnChange(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
