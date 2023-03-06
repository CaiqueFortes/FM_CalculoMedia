namespace FM_CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();

            aluno.Nome = txtNome.Text;
            aluno.Ra = txtRa.Text;
            aluno.P1 = Convert.ToDouble(txtP1.Text);
            aluno.P2 = Convert.ToDouble(txtP2.Text);

            aluno.CalcularMedia();

            txtMedia.Text = aluno.Media.ToString();
        }
    }
}