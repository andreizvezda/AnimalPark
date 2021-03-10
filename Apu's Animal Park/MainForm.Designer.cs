
namespace AnimalPark
{
    partial class MainForm
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
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.LabelEaterType = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblAnimalInfo = new System.Windows.Forms.Label();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.textBoxAnimalSpec = new System.Windows.Forms.TextBox();
            this.LabelSpeciesProperty = new System.Windows.Forms.Label();
            this.pictureBoxAnimal = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxAnimals = new System.Windows.Forms.CheckBox();
            this.groupBoxMammal = new System.Windows.Forms.GroupBox();
            this.comboBoxReptile = new System.Windows.Forms.ComboBox();
            this.txtTail = new System.Windows.Forms.Label();
            this.labelTeeth = new System.Windows.Forms.Label();
            this.textBoxTeeth = new System.Windows.Forms.TextBox();
            this.textBoxTail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.groupBoxgGender = new System.Windows.Forms.GroupBox();
            this.listBoxGender = new System.Windows.Forms.ListBox();
            this.groupBoxAnimal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).BeginInit();
            this.groupBoxMammal.SuspendLayout();
            this.groupBoxgGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Controls.Add(this.button1);
            this.groupBoxAnimal.Controls.Add(this.groupBox1);
            this.groupBoxAnimal.Controls.Add(this.groupBoxType);
            this.groupBoxAnimal.Controls.Add(this.pictureBoxAnimal);
            this.groupBoxAnimal.Controls.Add(this.buttonAdd);
            this.groupBoxAnimal.Controls.Add(this.checkBoxAnimals);
            this.groupBoxAnimal.Controls.Add(this.groupBoxMammal);
            this.groupBoxAnimal.Controls.Add(this.label2);
            this.groupBoxAnimal.Controls.Add(this.label1);
            this.groupBoxAnimal.Controls.Add(this.labelAge);
            this.groupBoxAnimal.Controls.Add(this.labelName);
            this.groupBoxAnimal.Controls.Add(this.textBoxAge);
            this.groupBoxAnimal.Controls.Add(this.textBoxName);
            this.groupBoxAnimal.Controls.Add(this.listBoxAnimal);
            this.groupBoxAnimal.Controls.Add(this.listBoxCategory);
            this.groupBoxAnimal.Controls.Add(this.groupBoxgGender);
            this.groupBoxAnimal.Location = new System.Drawing.Point(30, 32);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(847, 521);
            this.groupBoxAnimal.TabIndex = 0;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "ANIMAL SPECIFICATIONS";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(549, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(254, 160);
            this.listBox2.TabIndex = 23;
            // 
            // LabelEaterType
            // 
            this.LabelEaterType.AutoSize = true;
            this.LabelEaterType.Location = new System.Drawing.Point(549, 9);
            this.LabelEaterType.Name = "LabelEaterType";
            this.LabelEaterType.Size = new System.Drawing.Size(82, 13);
            this.LabelEaterType.TabIndex = 22;
            this.LabelEaterType.Text = "LabelEaterType";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "LOAD IMAGE OF THE ANIMAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelEaterType);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.lblAnimalInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 193);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST OF REGISTERED ANIMALS:";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(261, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 176);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // lblAnimalInfo
            // 
            this.lblAnimalInfo.AutoSize = true;
            this.lblAnimalInfo.Location = new System.Drawing.Point(15, 25);
            this.lblAnimalInfo.Name = "lblAnimalInfo";
            this.lblAnimalInfo.Size = new System.Drawing.Size(35, 13);
            this.lblAnimalInfo.TabIndex = 18;
            this.lblAnimalInfo.Text = "label4";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.textBoxAnimalSpec);
            this.groupBoxType.Controls.Add(this.LabelSpeciesProperty);
            this.groupBoxType.Location = new System.Drawing.Point(303, 211);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(252, 64);
            this.groupBoxType.TabIndex = 15;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "ANIMAL SPECIFICATIONS:";
            // 
            // textBoxAnimalSpec
            // 
            this.textBoxAnimalSpec.Location = new System.Drawing.Point(109, 24);
            this.textBoxAnimalSpec.Name = "textBoxAnimalSpec";
            this.textBoxAnimalSpec.Size = new System.Drawing.Size(114, 20);
            this.textBoxAnimalSpec.TabIndex = 16;
            // 
            // LabelSpeciesProperty
            // 
            this.LabelSpeciesProperty.AutoSize = true;
            this.LabelSpeciesProperty.Location = new System.Drawing.Point(34, 29);
            this.LabelSpeciesProperty.Name = "LabelSpeciesProperty";
            this.LabelSpeciesProperty.Size = new System.Drawing.Size(69, 13);
            this.LabelSpeciesProperty.TabIndex = 1;
            this.LabelSpeciesProperty.Text = "PROPERTY:";
            // 
            // pictureBoxAnimal
            // 
            this.pictureBoxAnimal.Location = new System.Drawing.Point(520, 16);
            this.pictureBoxAnimal.Name = "pictureBoxAnimal";
            this.pictureBoxAnimal.Size = new System.Drawing.Size(313, 189);
            this.pictureBoxAnimal.TabIndex = 13;
            this.pictureBoxAnimal.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(304, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 30);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "ADD THIS ANIMAL";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // checkBoxAnimals
            // 
            this.checkBoxAnimals.AutoSize = true;
            this.checkBoxAnimals.Location = new System.Drawing.Point(340, 179);
            this.checkBoxAnimals.Name = "checkBoxAnimals";
            this.checkBoxAnimals.Size = new System.Drawing.Size(121, 17);
            this.checkBoxAnimals.TabIndex = 11;
            this.checkBoxAnimals.Text = "LIST ALL ANIMALS";
            this.checkBoxAnimals.UseVisualStyleBackColor = true;
            this.checkBoxAnimals.CheckedChanged += new System.EventHandler(this.CheckBoxAnimals_CheckedChanged);
            // 
            // groupBoxMammal
            // 
            this.groupBoxMammal.Controls.Add(this.comboBoxReptile);
            this.groupBoxMammal.Controls.Add(this.txtTail);
            this.groupBoxMammal.Controls.Add(this.labelTeeth);
            this.groupBoxMammal.Controls.Add(this.textBoxTeeth);
            this.groupBoxMammal.Controls.Add(this.textBoxTail);
            this.groupBoxMammal.Location = new System.Drawing.Point(12, 211);
            this.groupBoxMammal.Name = "groupBoxMammal";
            this.groupBoxMammal.Size = new System.Drawing.Size(285, 96);
            this.groupBoxMammal.TabIndex = 10;
            this.groupBoxMammal.TabStop = false;
            this.groupBoxMammal.Text = "MAMMAL SPECIFICATIONS:";
            // 
            // comboBoxReptile
            // 
            this.comboBoxReptile.FormattingEnabled = true;
            this.comboBoxReptile.Location = new System.Drawing.Point(165, 32);
            this.comboBoxReptile.Name = "comboBoxReptile";
            this.comboBoxReptile.Size = new System.Drawing.Size(114, 21);
            this.comboBoxReptile.TabIndex = 15;
            this.comboBoxReptile.Visible = false;
            // 
            // txtTail
            // 
            this.txtTail.AutoSize = true;
            this.txtTail.Location = new System.Drawing.Point(12, 64);
            this.txtTail.Name = "txtTail";
            this.txtTail.Size = new System.Drawing.Size(105, 13);
            this.txtTail.TabIndex = 14;
            this.txtTail.Text = "TAIL LENGTH (CM):";
            // 
            // labelTeeth
            // 
            this.labelTeeth.AutoSize = true;
            this.labelTeeth.Location = new System.Drawing.Point(12, 35);
            this.labelTeeth.Name = "labelTeeth";
            this.labelTeeth.Size = new System.Drawing.Size(85, 13);
            this.labelTeeth.TabIndex = 13;
            this.labelTeeth.Text = "NO. OF TEETH:";
            // 
            // textBoxTeeth
            // 
            this.textBoxTeeth.Location = new System.Drawing.Point(165, 32);
            this.textBoxTeeth.Name = "textBoxTeeth";
            this.textBoxTeeth.Size = new System.Drawing.Size(114, 20);
            this.textBoxTeeth.TabIndex = 11;
            // 
            // textBoxTail
            // 
            this.textBoxTail.Location = new System.Drawing.Point(165, 59);
            this.textBoxTail.Name = "textBoxTail";
            this.textBoxTail.Size = new System.Drawing.Size(114, 20);
            this.textBoxTail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ANIMAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORY:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 68);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "AGE:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "NAME:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(50, 65);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(50, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.Location = new System.Drawing.Point(340, 39);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(148, 134);
            this.listBoxAnimal.TabIndex = 2;
            this.listBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.ListBoxAnimal_SelectedIndexChanged);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(177, 39);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(141, 134);
            this.listBoxCategory.TabIndex = 1;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategory_SelectedIndexChanged);
            // 
            // groupBoxgGender
            // 
            this.groupBoxgGender.Controls.Add(this.listBoxGender);
            this.groupBoxgGender.Location = new System.Drawing.Point(12, 91);
            this.groupBoxgGender.Name = "groupBoxgGender";
            this.groupBoxgGender.Size = new System.Drawing.Size(159, 82);
            this.groupBoxgGender.TabIndex = 9;
            this.groupBoxgGender.TabStop = false;
            this.groupBoxgGender.Text = "GENDER";
            // 
            // listBoxGender
            // 
            this.listBoxGender.FormattingEnabled = true;
            this.listBoxGender.Location = new System.Drawing.Point(18, 19);
            this.listBoxGender.Name = "listBoxGender";
            this.listBoxGender.Size = new System.Drawing.Size(120, 56);
            this.listBoxGender.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 554);
            this.Controls.Add(this.groupBoxAnimal);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimal)).EndInit();
            this.groupBoxMammal.ResumeLayout(false);
            this.groupBoxMammal.PerformLayout();
            this.groupBoxgGender.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.ListBox listBoxGender;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxAnimals;
        private System.Windows.Forms.GroupBox groupBoxMammal;
        private System.Windows.Forms.Label txtTail;
        private System.Windows.Forms.Label labelTeeth;
        private System.Windows.Forms.TextBox textBoxTeeth;
        private System.Windows.Forms.TextBox textBoxTail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxgGender;
        private System.Windows.Forms.PictureBox pictureBoxAnimal;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label LabelSpeciesProperty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAnimalInfo;
        private System.Windows.Forms.ComboBox comboBoxReptile;
        private System.Windows.Forms.TextBox textBoxAnimalSpec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelEaterType;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListView listView1;
    }
}

