namespace Het_dierenasiel
{
    partial class Form1
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.btnProductToevoegen = new System.Windows.Forms.Button();
            this.gbNieuwProduct = new System.Windows.Forms.GroupBox();
            this.lbProductenLijst = new System.Windows.Forms.ListBox();
            this.lblProductenLijst = new System.Windows.Forms.Label();
            this.btnProductKopen = new System.Windows.Forms.Button();
            this.lblGekochteProducten = new System.Windows.Forms.Label();
            this.lbVerkochteProducten = new System.Windows.Forms.ListBox();
            this.lblDierenasiel = new System.Windows.Forms.Label();
            this.lbDierenasiel = new System.Windows.Forms.ListBox();
            this.btnHondToevoegen = new System.Windows.Forms.Button();
            this.btnKatToevoegen = new System.Windows.Forms.Button();
            this.lblNamen = new System.Windows.Forms.Label();
            this.lblSoort = new System.Windows.Forms.Label();
            this.lblGewoonte = new System.Windows.Forms.Label();
            this.lblUitlaatDatum = new System.Windows.Forms.Label();
            this.tbNamen = new System.Windows.Forms.TextBox();
            this.tbUitlaatDatumy = new System.Windows.Forms.TextBox();
            this.tbGewoonte = new System.Windows.Forms.TextBox();
            this.tbSoort = new System.Windows.Forms.TextBox();
            this.tbUitlaatDatumm = new System.Windows.Forms.TextBox();
            this.tbUitlaatDatumd = new System.Windows.Forms.TextBox();
            this.lblYaar = new System.Windows.Forms.Label();
            this.lblMaand = new System.Windows.Forms.Label();
            this.lblDag = new System.Windows.Forms.Label();
            this.lblReserveringsLijst = new System.Windows.Forms.Label();
            this.lbReserveringsLijst = new System.Windows.Forms.ListBox();
            this.btnHuisdierReserveren = new System.Windows.Forms.Button();
            this.btnHuisdierVerwijderen = new System.Windows.Forms.Button();
            this.btnReservatieKopen = new System.Windows.Forms.Button();
            this.gbNieuwProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(6, 28);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Naam:";
            // 
            // tbNaam
            // 
            this.tbNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaam.Location = new System.Drawing.Point(76, 21);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(221, 22);
            this.tbNaam.TabIndex = 4;
            // 
            // tbPrijs
            // 
            this.tbPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrijs.Location = new System.Drawing.Point(76, 56);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(221, 22);
            this.tbPrijs.TabIndex = 5;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijs.Location = new System.Drawing.Point(6, 59);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(55, 17);
            this.lblPrijs.TabIndex = 6;
            this.lblPrijs.Text = "Prijs:  €";
            // 
            // btnProductToevoegen
            // 
            this.btnProductToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductToevoegen.Location = new System.Drawing.Point(6, 91);
            this.btnProductToevoegen.Name = "btnProductToevoegen";
            this.btnProductToevoegen.Size = new System.Drawing.Size(291, 33);
            this.btnProductToevoegen.TabIndex = 7;
            this.btnProductToevoegen.Text = "Toevoegen";
            this.btnProductToevoegen.UseVisualStyleBackColor = true;
            this.btnProductToevoegen.Click += new System.EventHandler(this.btnProductToevoegen_Click);
            // 
            // gbNieuwProduct
            // 
            this.gbNieuwProduct.Controls.Add(this.lblNaam);
            this.gbNieuwProduct.Controls.Add(this.btnProductToevoegen);
            this.gbNieuwProduct.Controls.Add(this.tbNaam);
            this.gbNieuwProduct.Controls.Add(this.lblPrijs);
            this.gbNieuwProduct.Controls.Add(this.tbPrijs);
            this.gbNieuwProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNieuwProduct.Location = new System.Drawing.Point(614, 12);
            this.gbNieuwProduct.Name = "gbNieuwProduct";
            this.gbNieuwProduct.Size = new System.Drawing.Size(303, 131);
            this.gbNieuwProduct.TabIndex = 8;
            this.gbNieuwProduct.TabStop = false;
            this.gbNieuwProduct.Text = "Nieuw Product";
            // 
            // lbProductenLijst
            // 
            this.lbProductenLijst.FormattingEnabled = true;
            this.lbProductenLijst.ItemHeight = 16;
            this.lbProductenLijst.Location = new System.Drawing.Point(614, 169);
            this.lbProductenLijst.Name = "lbProductenLijst";
            this.lbProductenLijst.Size = new System.Drawing.Size(255, 276);
            this.lbProductenLijst.TabIndex = 9;
            // 
            // lblProductenLijst
            // 
            this.lblProductenLijst.AutoSize = true;
            this.lblProductenLijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductenLijst.Location = new System.Drawing.Point(611, 146);
            this.lblProductenLijst.Name = "lblProductenLijst";
            this.lblProductenLijst.Size = new System.Drawing.Size(152, 17);
            this.lblProductenLijst.TabIndex = 10;
            this.lblProductenLijst.Text = "Lijst met producten:";
            // 
            // btnProductKopen
            // 
            this.btnProductKopen.Location = new System.Drawing.Point(614, 448);
            this.btnProductKopen.Name = "btnProductKopen";
            this.btnProductKopen.Size = new System.Drawing.Size(255, 36);
            this.btnProductKopen.TabIndex = 11;
            this.btnProductKopen.Text = "Product kopen";
            this.btnProductKopen.UseVisualStyleBackColor = true;
            this.btnProductKopen.Click += new System.EventHandler(this.btnProductKopen_Click);
            // 
            // lblGekochteProducten
            // 
            this.lblGekochteProducten.AutoSize = true;
            this.lblGekochteProducten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGekochteProducten.Location = new System.Drawing.Point(872, 146);
            this.lblGekochteProducten.Name = "lblGekochteProducten";
            this.lblGekochteProducten.Size = new System.Drawing.Size(228, 17);
            this.lblGekochteProducten.TabIndex = 12;
            this.lblGekochteProducten.Text = "Lijst met verkochte producten:";
            // 
            // lbVerkochteProducten
            // 
            this.lbVerkochteProducten.FormattingEnabled = true;
            this.lbVerkochteProducten.ItemHeight = 16;
            this.lbVerkochteProducten.Location = new System.Drawing.Point(875, 166);
            this.lbVerkochteProducten.Name = "lbVerkochteProducten";
            this.lbVerkochteProducten.Size = new System.Drawing.Size(255, 308);
            this.lbVerkochteProducten.TabIndex = 13;
            // 
            // lblDierenasiel
            // 
            this.lblDierenasiel.AutoSize = true;
            this.lblDierenasiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDierenasiel.Location = new System.Drawing.Point(13, 13);
            this.lblDierenasiel.Name = "lblDierenasiel";
            this.lblDierenasiel.Size = new System.Drawing.Size(95, 17);
            this.lblDierenasiel.TabIndex = 14;
            this.lblDierenasiel.Text = "Dierenasiel:";
            // 
            // lbDierenasiel
            // 
            this.lbDierenasiel.FormattingEnabled = true;
            this.lbDierenasiel.ItemHeight = 16;
            this.lbDierenasiel.Location = new System.Drawing.Point(13, 33);
            this.lbDierenasiel.Name = "lbDierenasiel";
            this.lbDierenasiel.Size = new System.Drawing.Size(202, 228);
            this.lbDierenasiel.TabIndex = 15;
            // 
            // btnHondToevoegen
            // 
            this.btnHondToevoegen.Location = new System.Drawing.Point(12, 315);
            this.btnHondToevoegen.Name = "btnHondToevoegen";
            this.btnHondToevoegen.Size = new System.Drawing.Size(203, 30);
            this.btnHondToevoegen.TabIndex = 16;
            this.btnHondToevoegen.Text = "Hond toevoegen";
            this.btnHondToevoegen.UseVisualStyleBackColor = true;
            this.btnHondToevoegen.Click += new System.EventHandler(this.btnHondToevoegen_Click);
            // 
            // btnKatToevoegen
            // 
            this.btnKatToevoegen.Location = new System.Drawing.Point(12, 279);
            this.btnKatToevoegen.Name = "btnKatToevoegen";
            this.btnKatToevoegen.Size = new System.Drawing.Size(203, 30);
            this.btnKatToevoegen.TabIndex = 17;
            this.btnKatToevoegen.Text = "Kat toevoegen";
            this.btnKatToevoegen.UseVisualStyleBackColor = true;
            this.btnKatToevoegen.Click += new System.EventHandler(this.btnKatToevoegen_Click);
            // 
            // lblNamen
            // 
            this.lblNamen.AutoSize = true;
            this.lblNamen.Location = new System.Drawing.Point(10, 361);
            this.lblNamen.Name = "lblNamen";
            this.lblNamen.Size = new System.Drawing.Size(49, 17);
            this.lblNamen.TabIndex = 18;
            this.lblNamen.Text = "Naam:";
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(10, 389);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(46, 17);
            this.lblSoort.TabIndex = 19;
            this.lblSoort.Text = "Soort:";
            // 
            // lblGewoonte
            // 
            this.lblGewoonte.AutoSize = true;
            this.lblGewoonte.Location = new System.Drawing.Point(10, 416);
            this.lblGewoonte.Name = "lblGewoonte";
            this.lblGewoonte.Size = new System.Drawing.Size(109, 17);
            this.lblGewoonte.TabIndex = 21;
            this.lblGewoonte.Text = "Gewoonte (kat):";
            // 
            // lblUitlaatDatum
            // 
            this.lblUitlaatDatum.AutoSize = true;
            this.lblUitlaatDatum.Location = new System.Drawing.Point(10, 445);
            this.lblUitlaatDatum.Name = "lblUitlaatDatum";
            this.lblUitlaatDatum.Size = new System.Drawing.Size(139, 17);
            this.lblUitlaatDatum.TabIndex = 22;
            this.lblUitlaatDatum.Text = "UitlaatDatum (hond):\r\n";
            // 
            // tbNamen
            // 
            this.tbNamen.Location = new System.Drawing.Point(158, 358);
            this.tbNamen.Name = "tbNamen";
            this.tbNamen.Size = new System.Drawing.Size(286, 22);
            this.tbNamen.TabIndex = 23;
            // 
            // tbUitlaatDatumy
            // 
            this.tbUitlaatDatumy.Location = new System.Drawing.Point(158, 440);
            this.tbUitlaatDatumy.Name = "tbUitlaatDatumy";
            this.tbUitlaatDatumy.Size = new System.Drawing.Size(57, 22);
            this.tbUitlaatDatumy.TabIndex = 24;
            // 
            // tbGewoonte
            // 
            this.tbGewoonte.Location = new System.Drawing.Point(158, 412);
            this.tbGewoonte.Name = "tbGewoonte";
            this.tbGewoonte.Size = new System.Drawing.Size(286, 22);
            this.tbGewoonte.TabIndex = 25;
            // 
            // tbSoort
            // 
            this.tbSoort.Location = new System.Drawing.Point(158, 384);
            this.tbSoort.Name = "tbSoort";
            this.tbSoort.Size = new System.Drawing.Size(286, 22);
            this.tbSoort.TabIndex = 27;
            // 
            // tbUitlaatDatumm
            // 
            this.tbUitlaatDatumm.Location = new System.Drawing.Point(263, 440);
            this.tbUitlaatDatumm.Name = "tbUitlaatDatumm";
            this.tbUitlaatDatumm.Size = new System.Drawing.Size(34, 22);
            this.tbUitlaatDatumm.TabIndex = 28;
            // 
            // tbUitlaatDatumd
            // 
            this.tbUitlaatDatumd.Location = new System.Drawing.Point(339, 438);
            this.tbUitlaatDatumd.Name = "tbUitlaatDatumd";
            this.tbUitlaatDatumd.Size = new System.Drawing.Size(34, 22);
            this.tbUitlaatDatumd.TabIndex = 30;
            // 
            // lblYaar
            // 
            this.lblYaar.AutoSize = true;
            this.lblYaar.Location = new System.Drawing.Point(221, 443);
            this.lblYaar.Name = "lblYaar";
            this.lblYaar.Size = new System.Drawing.Size(36, 17);
            this.lblYaar.TabIndex = 31;
            this.lblYaar.Text = "yyyy";
            // 
            // lblMaand
            // 
            this.lblMaand.AutoSize = true;
            this.lblMaand.Location = new System.Drawing.Point(303, 445);
            this.lblMaand.Name = "lblMaand";
            this.lblMaand.Size = new System.Drawing.Size(30, 17);
            this.lblMaand.TabIndex = 32;
            this.lblMaand.Text = "mm";
            // 
            // lblDag
            // 
            this.lblDag.AutoSize = true;
            this.lblDag.Location = new System.Drawing.Point(379, 443);
            this.lblDag.Name = "lblDag";
            this.lblDag.Size = new System.Drawing.Size(24, 17);
            this.lblDag.TabIndex = 33;
            this.lblDag.Text = "dd";
            // 
            // lblReserveringsLijst
            // 
            this.lblReserveringsLijst.AutoSize = true;
            this.lblReserveringsLijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveringsLijst.Location = new System.Drawing.Point(447, 9);
            this.lblReserveringsLijst.Name = "lblReserveringsLijst";
            this.lblReserveringsLijst.Size = new System.Drawing.Size(139, 17);
            this.lblReserveringsLijst.TabIndex = 36;
            this.lblReserveringsLijst.Text = "Reserverings lijst:";
            // 
            // lbReserveringsLijst
            // 
            this.lbReserveringsLijst.FormattingEnabled = true;
            this.lbReserveringsLijst.ItemHeight = 16;
            this.lbReserveringsLijst.Location = new System.Drawing.Point(450, 29);
            this.lbReserveringsLijst.Name = "lbReserveringsLijst";
            this.lbReserveringsLijst.Size = new System.Drawing.Size(158, 452);
            this.lbReserveringsLijst.TabIndex = 37;
            // 
            // btnHuisdierReserveren
            // 
            this.btnHuisdierReserveren.Location = new System.Drawing.Point(221, 279);
            this.btnHuisdierReserveren.Name = "btnHuisdierReserveren";
            this.btnHuisdierReserveren.Size = new System.Drawing.Size(220, 30);
            this.btnHuisdierReserveren.TabIndex = 38;
            this.btnHuisdierReserveren.Text = "Huisdier reserveren";
            this.btnHuisdierReserveren.UseVisualStyleBackColor = true;
            this.btnHuisdierReserveren.Click += new System.EventHandler(this.btnHuisdierReserveren_Click);
            // 
            // btnHuisdierVerwijderen
            // 
            this.btnHuisdierVerwijderen.Location = new System.Drawing.Point(221, 315);
            this.btnHuisdierVerwijderen.Name = "btnHuisdierVerwijderen";
            this.btnHuisdierVerwijderen.Size = new System.Drawing.Size(220, 30);
            this.btnHuisdierVerwijderen.TabIndex = 39;
            this.btnHuisdierVerwijderen.Text = "Huisdier verwijderen";
            this.btnHuisdierVerwijderen.UseVisualStyleBackColor = true;
            this.btnHuisdierVerwijderen.Click += new System.EventHandler(this.btnHuisdierVerwijderen_Click);
            // 
            // btnReservatieKopen
            // 
            this.btnReservatieKopen.Location = new System.Drawing.Point(221, 241);
            this.btnReservatieKopen.Name = "btnReservatieKopen";
            this.btnReservatieKopen.Size = new System.Drawing.Size(220, 32);
            this.btnReservatieKopen.TabIndex = 40;
            this.btnReservatieKopen.Text = "Reservatie kopen";
            this.btnReservatieKopen.UseVisualStyleBackColor = true;
            this.btnReservatieKopen.Click += new System.EventHandler(this.btnReservatieKopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 497);
            this.Controls.Add(this.btnReservatieKopen);
            this.Controls.Add(this.btnHuisdierVerwijderen);
            this.Controls.Add(this.btnHuisdierReserveren);
            this.Controls.Add(this.lbReserveringsLijst);
            this.Controls.Add(this.lblReserveringsLijst);
            this.Controls.Add(this.lblDag);
            this.Controls.Add(this.lblMaand);
            this.Controls.Add(this.lblYaar);
            this.Controls.Add(this.tbUitlaatDatumd);
            this.Controls.Add(this.tbUitlaatDatumm);
            this.Controls.Add(this.tbSoort);
            this.Controls.Add(this.tbGewoonte);
            this.Controls.Add(this.tbUitlaatDatumy);
            this.Controls.Add(this.tbNamen);
            this.Controls.Add(this.lblUitlaatDatum);
            this.Controls.Add(this.lblGewoonte);
            this.Controls.Add(this.lblSoort);
            this.Controls.Add(this.lblNamen);
            this.Controls.Add(this.btnKatToevoegen);
            this.Controls.Add(this.btnHondToevoegen);
            this.Controls.Add(this.lbDierenasiel);
            this.Controls.Add(this.lblDierenasiel);
            this.Controls.Add(this.lbVerkochteProducten);
            this.Controls.Add(this.lblGekochteProducten);
            this.Controls.Add(this.btnProductKopen);
            this.Controls.Add(this.lblProductenLijst);
            this.Controls.Add(this.lbProductenLijst);
            this.Controls.Add(this.gbNieuwProduct);
            this.Name = "Form1";
            this.Text = "Dierenasiel";
            this.gbNieuwProduct.ResumeLayout(false);
            this.gbNieuwProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Button btnProductToevoegen;
        private System.Windows.Forms.GroupBox gbNieuwProduct;
        private System.Windows.Forms.ListBox lbProductenLijst;
        private System.Windows.Forms.Label lblProductenLijst;
        private System.Windows.Forms.Button btnProductKopen;
        private System.Windows.Forms.Label lblGekochteProducten;
        private System.Windows.Forms.ListBox lbVerkochteProducten;
        private System.Windows.Forms.Label lblDierenasiel;
        private System.Windows.Forms.ListBox lbDierenasiel;
        private System.Windows.Forms.Button btnHondToevoegen;
        private System.Windows.Forms.Button btnKatToevoegen;
        private System.Windows.Forms.Label lblNamen;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Label lblGewoonte;
        private System.Windows.Forms.Label lblUitlaatDatum;
        private System.Windows.Forms.TextBox tbNamen;
        private System.Windows.Forms.TextBox tbUitlaatDatumy;
        private System.Windows.Forms.TextBox tbGewoonte;
        private System.Windows.Forms.TextBox tbSoort;
        private System.Windows.Forms.TextBox tbUitlaatDatumm;
        private System.Windows.Forms.TextBox tbUitlaatDatumd;
        private System.Windows.Forms.Label lblYaar;
        private System.Windows.Forms.Label lblMaand;
        private System.Windows.Forms.Label lblDag;
        private System.Windows.Forms.Label lblReserveringsLijst;
        private System.Windows.Forms.ListBox lbReserveringsLijst;
        private System.Windows.Forms.Button btnHuisdierReserveren;
        private System.Windows.Forms.Button btnHuisdierVerwijderen;
        private System.Windows.Forms.Button btnReservatieKopen;
    }
}

