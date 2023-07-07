namespace Censor
{
    partial class Censor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Censor));
            lblInsert = new Label();
            textInput = new TextBox();
            btnControl = new Button();
            lblResult = new Label();
            textOutput = new TextBox();
            clbChoose = new CheckedListBox();
            SuspendLayout();
            // 
            // lblInsert
            // 
            lblInsert.AutoSize = true;
            lblInsert.Location = new Point(149, 34);
            lblInsert.Name = "lblInsert";
            lblInsert.Size = new Size(60, 15);
            lblInsert.TabIndex = 0;
            lblInsert.Text = "Insert Text";
            // 
            // textInput
            // 
            textInput.BackColor = Color.LightBlue;
            textInput.Location = new Point(21, 52);
            textInput.Multiline = true;
            textInput.Name = "textInput";
            textInput.Size = new Size(339, 238);
            textInput.TabIndex = 1;
            // 
            // btnControl
            // 
            btnControl.BackColor = Color.LightBlue;
            btnControl.Location = new Point(115, 374);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(131, 27);
            btnControl.TabIndex = 2;
            btnControl.Text = "CONTROL TEXT";
            btnControl.UseVisualStyleBackColor = false;
            btnControl.Click += btnControl_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(561, 34);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(86, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result Window";
            // 
            // textOutput
            // 
            textOutput.BackColor = Color.LightBlue;
            textOutput.Location = new Point(416, 52);
            textOutput.Multiline = true;
            textOutput.Name = "textOutput";
            textOutput.Size = new Size(372, 349);
            textOutput.TabIndex = 4;
            // 
            // clbChoose
            // 
            clbChoose.BackColor = Color.SteelBlue;
            clbChoose.FormattingEnabled = true;
            clbChoose.Items.AddRange(new object[] { "Obscene words", "Violent words" });
            clbChoose.Location = new Point(115, 311);
            clbChoose.Name = "clbChoose";
            clbChoose.Size = new Size(131, 40);
            clbChoose.TabIndex = 7;
            // 
            // Censor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(clbChoose);
            Controls.Add(textOutput);
            Controls.Add(lblResult);
            Controls.Add(btnControl);
            Controls.Add(textInput);
            Controls.Add(lblInsert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Censor";
            Text = "Censor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsert;
        private TextBox textInput;
        private Button btnControl;
        private Label lblResult;
        private TextBox textOutput;
        private CheckedListBox clbChoose;
    }
}