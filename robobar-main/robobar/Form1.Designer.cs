
namespace robobar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chose_1 = new System.Windows.Forms.Button();
            this.make_1 = new System.Windows.Forms.Button();
            this.exit_1 = new System.Windows.Forms.Button();
            this.setings_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chose_1
            // 
            this.chose_1.AutoSize = true;
            this.chose_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chose_1.Location = new System.Drawing.Point(0, 0);
            this.chose_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chose_1.Name = "chose_1";
            this.chose_1.Size = new System.Drawing.Size(505, 585);
            this.chose_1.TabIndex = 0;
            this.chose_1.Text = "Выбор коктейля";
            this.chose_1.UseVisualStyleBackColor = true;
            this.chose_1.Click += new System.EventHandler(this.chose_1_Click_1);
            // 
            // make_1
            // 
            this.make_1.AutoSize = true;
            this.make_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.make_1.Location = new System.Drawing.Point(505, 0);
            this.make_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.make_1.Name = "make_1";
            this.make_1.Size = new System.Drawing.Size(623, 585);
            this.make_1.TabIndex = 1;
            this.make_1.Text = "Создание своего коктейля";
            this.make_1.UseVisualStyleBackColor = true;
            this.make_1.Click += new System.EventHandler(this.make_1_Click);
            // 
            // exit_1
            // 
            this.exit_1.AutoSize = true;
            this.exit_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_1.Location = new System.Drawing.Point(505, 389);
            this.exit_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_1.Name = "exit_1";
            this.exit_1.Size = new System.Drawing.Size(623, 196);
            this.exit_1.TabIndex = 2;
            this.exit_1.Text = "Выход";
            this.exit_1.UseVisualStyleBackColor = true;
            this.exit_1.Click += new System.EventHandler(this.exit_1_Click);
            // 
            // setings_1
            // 
            this.setings_1.AutoSize = true;
            this.setings_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.setings_1.Location = new System.Drawing.Point(505, 0);
            this.setings_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setings_1.Name = "setings_1";
            this.setings_1.Size = new System.Drawing.Size(623, 131);
            this.setings_1.TabIndex = 3;
            this.setings_1.Text = "Настройки";
            this.setings_1.UseVisualStyleBackColor = true;
            this.setings_1.Click += new System.EventHandler(this.setings_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1128, 585);
            this.Controls.Add(this.setings_1);
            this.Controls.Add(this.exit_1);
            this.Controls.Add(this.make_1);
            this.Controls.Add(this.chose_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робобар";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chose_1;
        private System.Windows.Forms.Button make_1;
        private System.Windows.Forms.Button exit_1;
        private System.Windows.Forms.Button setings_1;
    }
}

