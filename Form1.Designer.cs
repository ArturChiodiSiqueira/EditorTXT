namespace EditorTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuBar = new System.Windows.Forms.MenuStrip();
            mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            mCarregarImagem = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            mEditar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            mExibir = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            mExibirBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            mAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            statusBar = new System.Windows.Forms.StatusStrip();
            statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolBarNovo = new System.Windows.Forms.ToolStripButton();
            toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolBarFonte = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            toolBarZoomMenos = new System.Windows.Forms.ToolStripButton();
            toolBarZoom = new System.Windows.Forms.ToolStripButton();
            toolBarZoomMais = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            toolBarAjuda = new System.Windows.Forms.ToolStripButton();
            txtConteudo = new System.Windows.Forms.RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
            menuBar.Location = new System.Drawing.Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new System.Drawing.Size(782, 36);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mCarregarImagem, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            mArquivo.Size = new System.Drawing.Size(97, 32);
            mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            mArquivoNovo.Image = Properties.Resources.new_document;
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            mArquivoNovo.Size = new System.Drawing.Size(335, 32);
            mArquivoNovo.Text = "Novo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            mArquivoNovaJanela.Image = Properties.Resources.notes;
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.N;
            mArquivoNovaJanela.Size = new System.Drawing.Size(335, 32);
            mArquivoNovaJanela.Text = "Nova Janela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(332, 6);
            // 
            // mArquivoAbrir
            // 
            mArquivoAbrir.Image = Properties.Resources.folder;
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            mArquivoAbrir.Size = new System.Drawing.Size(335, 32);
            mArquivoAbrir.Text = "Abrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mCarregarImagem
            // 
            mCarregarImagem.Image = Properties.Resources.addimage;
            mCarregarImagem.Name = "mCarregarImagem";
            mCarregarImagem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I;
            mCarregarImagem.Size = new System.Drawing.Size(335, 32);
            mCarregarImagem.Text = "Imagem";
            mCarregarImagem.Click += mCarregarImagem_Click;
            // 
            // mArquivoSalvar
            // 
            mArquivoSalvar.Image = Properties.Resources.save;
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            mArquivoSalvar.Size = new System.Drawing.Size(335, 32);
            mArquivoSalvar.Text = "Salvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            mArquivoSalvarComo.Image = Properties.Resources.save;
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            mArquivoSalvarComo.Size = new System.Drawing.Size(335, 32);
            mArquivoSalvarComo.Text = "Salvar Como";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(332, 6);
            // 
            // mArquivoSair
            // 
            mArquivoSair.Image = Properties.Resources.exit;
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mArquivoSair.Size = new System.Drawing.Size(335, 32);
            mArquivoSair.Text = "Sair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataEHora });
            mEditar.Name = "mEditar";
            mEditar.Size = new System.Drawing.Size(77, 32);
            mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            mEditarDesfazer.Size = new System.Drawing.Size(245, 32);
            mEditarDesfazer.Text = "Desfazer";
            mEditarDesfazer.Click += mEditarDesfazer_Click;
            // 
            // mEditarRefazer
            // 
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y;
            mEditarRefazer.Size = new System.Drawing.Size(245, 32);
            mEditarRefazer.Text = "Refazer";
            mEditarRefazer.Click += mEditarRefazer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // mEditarRecortar
            // 
            mEditarRecortar.Image = Properties.Resources.text;
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            mEditarRecortar.Size = new System.Drawing.Size(245, 32);
            mEditarRecortar.Text = "Recortar";
            mEditarRecortar.Click += mEditarRecortar_Click;
            // 
            // mEditarCopiar
            // 
            mEditarCopiar.Image = Properties.Resources.text;
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            mEditarCopiar.Size = new System.Drawing.Size(245, 32);
            mEditarCopiar.Text = "Copiar";
            mEditarCopiar.Click += mEditarCopiar_Click;
            // 
            // mEditarColar
            // 
            mEditarColar.Image = Properties.Resources.text;
            mEditarColar.Name = "mEditarColar";
            mEditarColar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            mEditarColar.Size = new System.Drawing.Size(245, 32);
            mEditarColar.Text = "Colar";
            mEditarColar.Click += mEditarColar_Click;
            // 
            // mEditarExcluir
            // 
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            mEditarExcluir.Size = new System.Drawing.Size(245, 32);
            mEditarExcluir.Text = "Excluir";
            mEditarExcluir.Click += mEditarExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // mEditarDataEHora
            // 
            mEditarDataEHora.Name = "mEditarDataEHora";
            mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            mEditarDataEHora.Size = new System.Drawing.Size(245, 32);
            mEditarDataEHora.Text = "Data e Hora";
            mEditarDataEHora.Click += mEditarDataEHora_Click;
            // 
            // mFormatar
            // 
            mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mFormatarQuebraLinha, mFormatarFonte });
            mFormatar.Name = "mFormatar";
            mFormatar.Size = new System.Drawing.Size(107, 32);
            mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            mFormatarQuebraLinha.CheckOnClick = true;
            mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            mFormatarQuebraLinha.Size = new System.Drawing.Size(358, 32);
            mFormatarQuebraLinha.Text = "Quebra Automática de Linha";
            mFormatarQuebraLinha.Click += mFormatarQuebraLinha_Click;
            // 
            // mFormatarFonte
            // 
            mFormatarFonte.Name = "mFormatarFonte";
            mFormatarFonte.Size = new System.Drawing.Size(358, 32);
            mFormatarFonte.Text = "Fonte";
            mFormatarFonte.Click += mFormatarFonte_Click;
            // 
            // mExibir
            // 
            mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mExibirZoom, mExibirBarraStatus });
            mExibir.Name = "mExibir";
            mExibir.Size = new System.Drawing.Size(75, 32);
            mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
            mExibirZoom.Image = Properties.Resources.zoom1;
            mExibirZoom.Name = "mExibirZoom";
            mExibirZoom.Size = new System.Drawing.Size(234, 32);
            mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            mExibirZoomAmpliar.Image = Properties.Resources.zoom;
            mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl+adição";
            mExibirZoomAmpliar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            mExibirZoomAmpliar.Size = new System.Drawing.Size(303, 32);
            mExibirZoomAmpliar.Text = "Ampliar";
            mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
            // 
            // mExibirZoomReduzir
            // 
            mExibirZoomReduzir.Image = Properties.Resources.zoom;
            mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl+sibtração";
            mExibirZoomReduzir.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            mExibirZoomReduzir.Size = new System.Drawing.Size(303, 32);
            mExibirZoomReduzir.Text = "Reduzir";
            mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
            // 
            // mExibirZoomRestaurar
            // 
            mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            mExibirZoomRestaurar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0;
            mExibirZoomRestaurar.Size = new System.Drawing.Size(303, 32);
            mExibirZoomRestaurar.Text = "Restaurar";
            mExibirZoomRestaurar.Click += mExibirZoomRestaurar_Click;
            // 
            // mExibirBarraStatus
            // 
            mExibirBarraStatus.Checked = true;
            mExibirBarraStatus.CheckOnClick = true;
            mExibirBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            mExibirBarraStatus.Name = "mExibirBarraStatus";
            mExibirBarraStatus.Size = new System.Drawing.Size(234, 32);
            mExibirBarraStatus.Text = "Barra de Status";
            mExibirBarraStatus.Click += mExibirBarraStatus_Click;
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mAjudaExibirAjuda, mAjudaSobre });
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new System.Drawing.Size(78, 32);
            mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            mAjudaExibirAjuda.Image = Properties.Resources.help;
            mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            mAjudaExibirAjuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            mAjudaExibirAjuda.Size = new System.Drawing.Size(235, 32);
            mAjudaExibirAjuda.Text = "Exibir Ajuda";
            mAjudaExibirAjuda.Click += mAjudaExibirAjuda_Click;
            // 
            // mAjudaSobre
            // 
            mAjudaSobre.Image = Properties.Resources.info;
            mAjudaSobre.Name = "mAjudaSobre";
            mAjudaSobre.ShortcutKeys = System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8;
            mAjudaSobre.ShowShortcutKeys = false;
            mAjudaSobre.Size = new System.Drawing.Size(235, 32);
            mAjudaSobre.Text = "Sobre o Editor";
            mAjudaSobre.Click += mAjudaSobre_Click;
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusBarLabel });
            statusBar.Location = new System.Drawing.Point(0, 527);
            statusBar.Name = "statusBar";
            statusBar.Size = new System.Drawing.Size(782, 26);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new System.Drawing.Size(49, 20);
            statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBarNovo, toolBarAbrir, toolBarSalvar, toolStripSeparator5, toolBarFonte, toolStripSeparator6, toolBarZoomMenos, toolBarZoom, toolBarZoomMais, toolStripSeparator7, toolBarAjuda });
            toolStrip1.Location = new System.Drawing.Point(0, 36);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(782, 35);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNovo
            // 
            toolBarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarNovo.Image = Properties.Resources.new_document;
            toolBarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarNovo.Name = "toolBarNovo";
            toolBarNovo.Size = new System.Drawing.Size(29, 32);
            toolBarNovo.Text = "Novo";
            toolBarNovo.Click += mArquivoNovo_Click;
            // 
            // toolBarAbrir
            // 
            toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarAbrir.Image = Properties.Resources.folder;
            toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarAbrir.Name = "toolBarAbrir";
            toolBarAbrir.Size = new System.Drawing.Size(29, 32);
            toolBarAbrir.Text = "Abrir";
            toolBarAbrir.Click += mArquivoAbrir_Click;
            // 
            // toolBarSalvar
            // 
            toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarSalvar.Image = Properties.Resources.save;
            toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarSalvar.Name = "toolBarSalvar";
            toolBarSalvar.Size = new System.Drawing.Size(29, 32);
            toolBarSalvar.Text = "Salvar";
            toolBarSalvar.Click += mArquivoSalvar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // toolBarFonte
            // 
            toolBarFonte.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            toolBarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolBarFonte.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            toolBarFonte.Image = (System.Drawing.Image)resources.GetObject("toolBarFonte.Image");
            toolBarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarFonte.Name = "toolBarFonte";
            toolBarFonte.Size = new System.Drawing.Size(29, 32);
            toolBarFonte.Text = "A";
            toolBarFonte.ToolTipText = "Formatar";
            toolBarFonte.Click += mFormatarFonte_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // toolBarZoomMenos
            // 
            toolBarZoomMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolBarZoomMenos.ForeColor = System.Drawing.Color.Red;
            toolBarZoomMenos.Image = Properties.Resources.zoom;
            toolBarZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoomMenos.Name = "toolBarZoomMenos";
            toolBarZoomMenos.Size = new System.Drawing.Size(44, 32);
            toolBarZoomMenos.Text = "-";
            toolBarZoomMenos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            toolBarZoomMenos.ToolTipText = "- Zoom";
            toolBarZoomMenos.Click += mExibirZoomReduzir_Click;
            // 
            // toolBarZoom
            // 
            toolBarZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarZoom.Image = Properties.Resources.zoom;
            toolBarZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoom.Name = "toolBarZoom";
            toolBarZoom.Size = new System.Drawing.Size(29, 32);
            toolBarZoom.Text = "Zoom 100%";
            toolBarZoom.Click += mExibirZoomRestaurar_Click;
            // 
            // toolBarZoomMais
            // 
            toolBarZoomMais.ForeColor = System.Drawing.Color.Green;
            toolBarZoomMais.Image = Properties.Resources.zoom;
            toolBarZoomMais.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoomMais.Name = "toolBarZoomMais";
            toolBarZoomMais.Size = new System.Drawing.Size(43, 32);
            toolBarZoomMais.Text = "+";
            toolBarZoomMais.ToolTipText = "+ Zoom";
            toolBarZoomMais.Click += mExibirZoomAmpliar_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // toolBarAjuda
            // 
            toolBarAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarAjuda.Image = Properties.Resources.help;
            toolBarAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarAjuda.Name = "toolBarAjuda";
            toolBarAjuda.Size = new System.Drawing.Size(29, 32);
            toolBarAjuda.Text = "Ajuda";
            toolBarAjuda.Click += mAjudaExibirAjuda_Click;
            // 
            // txtConteudo
            // 
            txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            txtConteudo.Location = new System.Drawing.Point(0, 71);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new System.Drawing.Size(782, 456);
            txtConteudo.TabIndex = 4;
            txtConteudo.Text = "";
            txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 553);
            Controls.Add(txtConteudo);
            Controls.Add(toolStrip1);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBar;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "EditorTXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRefazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mEditarDataEHora;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibirAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.ToolStripButton toolBarNovo;
        private System.Windows.Forms.ToolStripButton toolBarAbrir;
        private System.Windows.Forms.ToolStripButton toolBarSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolBarFonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolBarZoomMenos;
        private System.Windows.Forms.ToolStripButton toolBarZoomMais;
        private System.Windows.Forms.ToolStripButton toolBarZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolBarAjuda;
        private System.Windows.Forms.ToolStripMenuItem mCarregarImagem;
    }
}
