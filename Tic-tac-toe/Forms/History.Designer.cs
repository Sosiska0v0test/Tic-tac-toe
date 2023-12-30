using System.ComponentModel;
using System.Drawing;

namespace Tic_tac_toe.Forms;

partial class History
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
        GameHistryArea = new System.Windows.Forms.TextBox();
        B_back = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // 
        // GameHistryArea
        // 
        GameHistryArea.Font = new Font("MS PGothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        GameHistryArea.Location = new Point(15, 3);
        GameHistryArea.Multiline = true;
        GameHistryArea.Name = "GameHistryArea";
        GameHistryArea.Size = new Size(908, 385);
        GameHistryArea.TabIndex = 0;
        GameHistryArea.TextChanged += GameHistryArea_TextChanged;

        // 
        // B_back
        // 
        B_back.BackColor = Color.FromArgb(34, 34, 34);
        B_back.FlatAppearance.BorderSize = 2;
        B_back.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
        B_back.ForeColor = Color.FromArgb(212, 160, 167);
        B_back.Location = new Point(463, 396);
        B_back.Name = "B_back";
        B_back.Size = new Size(73, 40);
        B_back.TabIndex = 1;
        B_back.Text = "Back";
        B_back.UseVisualStyleBackColor = false;
        B_back.Click += B_back_Click;

        // 
        // History
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(937, 448);
        Controls.Add(B_back);
        Controls.Add(GameHistryArea);
        Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        Name = "History";
        Text = "History";
        Load += new System.EventHandler(History_Load);
        ResumeLayout(false);
        PerformLayout();

    }

    private System.Windows.Forms.Button B_back;

    private System.Windows.Forms.TextBox GameHistryArea;

    #endregion
}