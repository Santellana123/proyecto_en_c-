namespace proyecto0._4
{
    partial class ganar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(348, 199);
            button1.Name = "button1";
            button1.Size = new Size(111, 61);
            button1.TabIndex = 0;
            button1.Text = "VOLVER A JUGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(348, 280);
            button2.Name = "button2";
            button2.Size = new Size(111, 61);
            button2.TabIndex = 1;
            button2.Text = "MENU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(348, 365);
            button3.Name = "button3";
            button3.Size = new Size(111, 61);
            button3.TabIndex = 2;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 68);
            label1.Name = "label1";
            label1.Size = new Size(274, 57);
            label1.TabIndex = 3;
            label1.Text = "VICTORIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(348, 163);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // ganar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ganar";
            Text = "ganar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
    }
}