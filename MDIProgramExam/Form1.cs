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

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formindex = this.MdiChildren.Length;
            Form ChildForm = new Form(); //шинээр форм үүсгэх
            ChildForm.Name = "Child" + (formindex + 1).ToString(); //формын нэр зааж байна
            ChildForm.Text = "Child" + (formindex + 1).ToString(); //формын гарчиг зааж байна.
            ChildForm.MdiParent = this; //Эцэг цонхыг зааж байна.
            TextBox txtBox = new TextBox(); //текст бичих талбар үүсгэж байна
            txtBox.Dock = DockStyle.Fill; //форм дээр дүүргэж байна.
            txtBox.Multiline = true; // олон мөр текст бичих боломжтой болно.
            ChildForm.Controls.Add(txtBox); // хүү формын контролуудын массивт нэмж байна.
            ChildForm.Show(); // хүү формыг харагдуулж байна.
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
