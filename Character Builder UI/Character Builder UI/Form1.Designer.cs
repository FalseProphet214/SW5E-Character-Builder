using System;
using System.ComponentModel;

namespace Character_Builder_UI
{
    partial class SW5ECB
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
            this.label1 = new System.Windows.Forms.Label();
            this.race1 = new System.Windows.Forms.Label();
            this.class1 = new System.Windows.Forms.Label();
            this.subClass = new System.Windows.Forms.Label();
            this.abilitiesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character Name";
            // 
            // race1
            // 
            this.race1.AutoSize = true;
            this.race1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race1.Location = new System.Drawing.Point(15, 49);
            this.race1.Name = "race1";
            this.race1.Size = new System.Drawing.Size(54, 24);
            this.race1.TabIndex = 1;
            this.race1.Text = "Race";
            // 
            // class1
            // 
            this.class1.AutoSize = true;
            this.class1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class1.Location = new System.Drawing.Point(15, 73);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(55, 24);
            this.class1.TabIndex = 2;
            this.class1.Text = "Class";
            // 
            // subClass
            // 
            this.subClass.AutoSize = true;
            this.subClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subClass.Location = new System.Drawing.Point(76, 73);
            this.subClass.Name = "subClass";
            this.subClass.Size = new System.Drawing.Size(89, 24);
            this.subClass.TabIndex = 3;
            this.subClass.Text = "SubClass";
            // 
            // abilitiesList
            // 
            this.abilitiesList.FormattingEnabled = true;
            this.abilitiesList.Location = new System.Drawing.Point(19, 120);
            this.abilitiesList.Name = "abilitiesList";
            this.abilitiesList.Size = new System.Drawing.Size(146, 409);
            this.abilitiesList.TabIndex = 4;
            // 
            // SW5ECB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.abilitiesList);
            this.Controls.Add(this.subClass);
            this.Controls.Add(this.class1);
            this.Controls.Add(this.race1);
            this.Controls.Add(this.label1);
            this.Name = "SW5ECB";
            this.Text = "SW5E Character builder v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label race1;
        private System.Windows.Forms.Label class1;
        private System.Windows.Forms.Label subClass;
        private System.Windows.Forms.CheckedListBox abilitiesList;
    }
}

