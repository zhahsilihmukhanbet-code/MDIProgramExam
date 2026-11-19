namespace MDIProgramExam
{
    public partial class Form1 : Form
    {
        int formindex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MDI Текст Боловсруулагч";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formindex = this.MdiChildren.Length;
            Form ChildForm = new Form(); //шинээр форм үүсгэх
            ChildForm.Name = "Child" + (formindex + 1).ToString(); //формын нэр зааж байна
            ChildForm.Text = "Child" + (formindex + 1).ToString(); //формын гарчиг зааж байна.
            ChildForm.MdiParent = this; //Эцэг цонхыг зааж байна.
            ChildForm.Size = new Size(450, 300); // хүү формын анхны хэмжээг зааж байна.
            TextBox txtBox = new TextBox(); //текст бичих талбар үүсгэж байна   
            txtBox.Dock = DockStyle.Fill; //форм дээр дүүргэж байна.
            txtBox.Multiline = true; // олон мөр текст бичих боломжтой болно.
            txtBox.AcceptsReturn = true; // Enter дарахад шинэ мөр болгоно.
            txtBox.ScrollBars = ScrollBars.Both; // хэвтээ ба босоо гүйлгэх самбар нэмнэ.
            txtBox.Font = new Font("Segoe UI", 11); // текстийн хэмжээ болон фонт тохируулна.
            ChildForm.Controls.Add(txtBox); // хүү формын контролуудын массивт нэмж байна.
            ChildForm.Show(); // хүү формыг харагдуулж байна.
            txtBox.Focus(); // шинэ цонх нээгдэхэд шууд текст бичихэд бэлэн болгоно.
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}