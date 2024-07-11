namespace EasyGame;

public partial class Game : Form
{
    public Game()
    {
        InitializeComponent();
    }

    int num;
    private void button1_Click(object sender, EventArgs e)
    {
        num++;
        Number.Text = num.ToString();
    }
}
