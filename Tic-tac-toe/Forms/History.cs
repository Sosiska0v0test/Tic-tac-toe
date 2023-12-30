using System;
using System.Threading;
using System.Windows.Forms;
using ConsoleTables;

namespace Tic_tac_toe.Forms;

public partial class History : Form
{
    public History()
    {
        InitializeComponent();
        AddHistoryText();
    }

    private void AddHistoryText()
    {
        var table = new ConsoleTable("Index","First Player","Accaount Type", "Second Player","Accaount Type", "Winner", "Rating","FirstPlayer Score","SecondPlayer Score","Game Type");
        int i = 0;
        foreach (var item in MainGameWindow.DataBase.GameInfo)
        {
            table.AddRow($"{i++}",
                $"{item.Player1?.Name ?? "N/A",10}",
                $"{item.Player1?.GetType().Name ?? "N/A",18}",
                $"{item.Player2?.Name ?? "N/A",18}",
                $"{item.Player2?.GetType().Name ?? "N/A",18}",
                $"{item.Winner ?? "N/A",18}",
                $"{item.Rating,18}",
                $"{item.Player1?.Score ?? 0,18}",
                $"{item.Player2?.Score ?? 0,15}",
                $"{item.GetType().Name,18}");
        }
        GameHistryArea.Text = table.ToMinimalString();
    }

    private void B_back_Click(object sender, EventArgs e)
    {
        Visible = false;
        Thread.Sleep(150);
        StartingWindow.StartWindow.Visible = true;
    }

    private void GameHistryArea_TextChanged(object sender, EventArgs e)
    {

    }

    private void History_Load(object sender, EventArgs e)
    {

    }
}