using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using SVGLib;

namespace SVGPad
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		// my stuff
		private SvgDoc m_svg;
		private string m_sFileName;
		private Hashtable m_lvstate; // store the ListView group item state

		private SvgElement m_eleClipboard;

		// UI stuff
		private System.Windows.Forms.ToolBar tbMain;
		private System.Windows.Forms.ToolBarButton tbtnNew;
		private System.Windows.Forms.ToolBarButton tbtnOpen;
		private System.Windows.Forms.StatusBar sb;
		private System.Windows.Forms.ImageList img;
		private System.Windows.Forms.ToolBarButton sep1;
		private System.Windows.Forms.ToolBarButton sep2;
		private System.Windows.Forms.ToolBarButton tbtnPreview;
		private System.Windows.Forms.ToolBarButton sep3;
		private System.Windows.Forms.ToolBarButton tbtnExit;
		private System.Windows.Forms.ContextMenu mnuSvgEdit;
		private System.Windows.Forms.ToolBarButton tbtnSave;
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.TextBox txtXML;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Panel panelList;
		private System.Windows.Forms.ImageList imgListView;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.MenuItem menuCut;
		private System.Windows.Forms.MenuItem menuCopy;
		private System.Windows.Forms.MenuItem menuPaste;
		private System.Windows.Forms.MenuItem menuDelete;
		private System.Windows.Forms.MenuItem menuMoveUp;
		private System.Windows.Forms.MenuItem menuMoveDown;
		private System.Windows.Forms.MenuItem menuInsert;
		private System.Windows.Forms.MenuItem menuEdit2;
		private System.Windows.Forms.MenuItem menuEdit_rect;
		private System.Windows.Forms.MenuItem menuEdit_group;
		private System.Windows.Forms.MenuItem menuEdit_description;
		private System.Windows.Forms.MenuItem menuEdit_text;
		private System.Windows.Forms.MenuItem menuEdit_circle;
		private System.Windows.Forms.ImageList imgTB;
		private System.Windows.Forms.ToolBarButton tbtnDesc;
		private System.Windows.Forms.ToolBarButton tbtnText;
		private System.Windows.Forms.ToolBarButton tbtnGroup;
		private System.Windows.Forms.ToolBarButton tbtnRect;
		private System.Windows.Forms.ToolBarButton tbtnCircle;
		private System.Windows.Forms.ToolBarButton tbtnEllipse;
		private System.Windows.Forms.ToolBarButton tbtnLine;
		private System.Windows.Forms.ToolBarButton tbtnPath;
		private System.Windows.Forms.ToolBarButton tbtnPolygon;
		private System.Windows.Forms.ToolBarButton tbtnCut;
		private System.Windows.Forms.ToolBarButton tbtnCopy;
		private System.Windows.Forms.ToolBarButton tbtnPaste;
		private System.Windows.Forms.ToolBarButton tbtnDelete;
		private System.Windows.Forms.ToolBarButton tbtnPositionUp;
		private System.Windows.Forms.ToolBarButton tbtnPositionDown;
		private System.Windows.Forms.ToolBarButton tbtnLevelUp;
		private System.Windows.Forms.ToolBarButton tbtnAbout;
		private System.Windows.Forms.ToolBarButton tbtnImage;
		private System.Windows.Forms.PropertyGrid pgrid;
		private System.Windows.Forms.MenuItem menuEdit_ellipse;
		private System.Windows.Forms.MenuItem menuEdit_line;
		private System.Windows.Forms.MenuItem menuEdit_path;
		private System.Windows.Forms.MenuItem menuEdit_polygon;
		private System.Windows.Forms.MenuItem menuEdit_image;
		private System.ComponentModel.IContainer components;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
			m_eleClipboard = null;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.tbMain = new System.Windows.Forms.ToolBar();
			this.tbtnNew = new System.Windows.Forms.ToolBarButton();
			this.tbtnOpen = new System.Windows.Forms.ToolBarButton();
			this.tbtnSave = new System.Windows.Forms.ToolBarButton();
			this.tbtnPreview = new System.Windows.Forms.ToolBarButton();
			this.sep1 = new System.Windows.Forms.ToolBarButton();
			this.tbtnDesc = new System.Windows.Forms.ToolBarButton();
			this.tbtnText = new System.Windows.Forms.ToolBarButton();
			this.tbtnGroup = new System.Windows.Forms.ToolBarButton();
			this.tbtnRect = new System.Windows.Forms.ToolBarButton();
			this.tbtnCircle = new System.Windows.Forms.ToolBarButton();
			this.tbtnEllipse = new System.Windows.Forms.ToolBarButton();
			this.tbtnLine = new System.Windows.Forms.ToolBarButton();
			this.tbtnPath = new System.Windows.Forms.ToolBarButton();
			this.tbtnPolygon = new System.Windows.Forms.ToolBarButton();
			this.tbtnImage = new System.Windows.Forms.ToolBarButton();
			this.sep2 = new System.Windows.Forms.ToolBarButton();
			this.tbtnCut = new System.Windows.Forms.ToolBarButton();
			this.tbtnCopy = new System.Windows.Forms.ToolBarButton();
			this.tbtnPaste = new System.Windows.Forms.ToolBarButton();
			this.tbtnDelete = new System.Windows.Forms.ToolBarButton();
			this.tbtnPositionUp = new System.Windows.Forms.ToolBarButton();
			this.tbtnPositionDown = new System.Windows.Forms.ToolBarButton();
			this.tbtnLevelUp = new System.Windows.Forms.ToolBarButton();
			this.sep3 = new System.Windows.Forms.ToolBarButton();
			this.tbtnAbout = new System.Windows.Forms.ToolBarButton();
			this.tbtnExit = new System.Windows.Forms.ToolBarButton();
			this.imgTB = new System.Windows.Forms.ImageList(this.components);
			this.mnuSvgEdit = new System.Windows.Forms.ContextMenu();
			this.menuInsert = new System.Windows.Forms.MenuItem();
			this.menuEdit_group = new System.Windows.Forms.MenuItem();
			this.menuEdit_description = new System.Windows.Forms.MenuItem();
			this.menuEdit_text = new System.Windows.Forms.MenuItem();
			this.menuEdit_rect = new System.Windows.Forms.MenuItem();
			this.menuEdit_circle = new System.Windows.Forms.MenuItem();
			this.menuEdit_ellipse = new System.Windows.Forms.MenuItem();
			this.menuEdit_line = new System.Windows.Forms.MenuItem();
			this.menuEdit_path = new System.Windows.Forms.MenuItem();
			this.menuEdit_polygon = new System.Windows.Forms.MenuItem();
			this.menuEdit_image = new System.Windows.Forms.MenuItem();
			this.menuEdit2 = new System.Windows.Forms.MenuItem();
			this.menuCut = new System.Windows.Forms.MenuItem();
			this.menuCopy = new System.Windows.Forms.MenuItem();
			this.menuPaste = new System.Windows.Forms.MenuItem();
			this.menuDelete = new System.Windows.Forms.MenuItem();
			this.menuMoveUp = new System.Windows.Forms.MenuItem();
			this.menuMoveDown = new System.Windows.Forms.MenuItem();
			this.sb = new System.Windows.Forms.StatusBar();
			this.img = new System.Windows.Forms.ImageList(this.components);
			this.panelMain = new System.Windows.Forms.Panel();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panelList = new System.Windows.Forms.Panel();
			this.pgrid = new System.Windows.Forms.PropertyGrid();
			this.txtXML = new System.Windows.Forms.TextBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.tv = new System.Windows.Forms.TreeView();
			this.imgListView = new System.Windows.Forms.ImageList(this.components);
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.panelMain.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.panelList.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbMain
			// 
			this.tbMain.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbMain.AutoSize = false;
			this.tbMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					  this.tbtnNew,
																					  this.tbtnOpen,
																					  this.tbtnSave,
																					  this.tbtnPreview,
																					  this.sep1,
																					  this.tbtnDesc,
																					  this.tbtnText,
																					  this.tbtnGroup,
																					  this.tbtnRect,
																					  this.tbtnCircle,
																					  this.tbtnEllipse,
																					  this.tbtnLine,
																					  this.tbtnPath,
																					  this.tbtnPolygon,
																					  this.tbtnImage,
																					  this.sep2,
																					  this.tbtnCut,
																					  this.tbtnCopy,
																					  this.tbtnPaste,
																					  this.tbtnDelete,
																					  this.tbtnPositionUp,
																					  this.tbtnPositionDown,
																					  this.tbtnLevelUp,
																					  this.sep3,
																					  this.tbtnAbout,
																					  this.tbtnExit});
			this.tbMain.ButtonSize = new System.Drawing.Size(22, 22);
			this.tbMain.DropDownArrows = true;
			this.tbMain.ImageList = this.imgTB;
			this.tbMain.Location = new System.Drawing.Point(5, 5);
			this.tbMain.Name = "tbMain";
			this.tbMain.ShowToolTips = true;
			this.tbMain.Size = new System.Drawing.Size(782, 32);
			this.tbMain.TabIndex = 0;
			this.tbMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbMain_ButtonClick);
			// 
			// tbtnNew
			// 
			this.tbtnNew.ImageIndex = 0;
			this.tbtnNew.Tag = "";
			this.tbtnNew.ToolTipText = "create a new svg document";
			// 
			// tbtnOpen
			// 
			this.tbtnOpen.ImageIndex = 1;
			this.tbtnOpen.Tag = "";
			this.tbtnOpen.ToolTipText = "open a svg file";
			// 
			// tbtnSave
			// 
			this.tbtnSave.ImageIndex = 2;
			this.tbtnSave.ToolTipText = "save the current svg document";
			// 
			// tbtnPreview
			// 
			this.tbtnPreview.ImageIndex = 20;
			this.tbtnPreview.ToolTipText = "see a previes in a browser";
			// 
			// sep1
			// 
			this.sep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbtnDesc
			// 
			this.tbtnDesc.ImageIndex = 3;
			this.tbtnDesc.ToolTipText = "insert a description element";
			// 
			// tbtnText
			// 
			this.tbtnText.ImageIndex = 4;
			this.tbtnText.ToolTipText = "insert a text element";
			// 
			// tbtnGroup
			// 
			this.tbtnGroup.ImageIndex = 5;
			this.tbtnGroup.ToolTipText = "insert a group element";
			// 
			// tbtnRect
			// 
			this.tbtnRect.ImageIndex = 6;
			this.tbtnRect.ToolTipText = "insert a rect element";
			// 
			// tbtnCircle
			// 
			this.tbtnCircle.ImageIndex = 7;
			this.tbtnCircle.ToolTipText = "insert a circle element";
			// 
			// tbtnEllipse
			// 
			this.tbtnEllipse.ImageIndex = 8;
			this.tbtnEllipse.ToolTipText = "insert an ellipse element";
			// 
			// tbtnLine
			// 
			this.tbtnLine.ImageIndex = 9;
			this.tbtnLine.ToolTipText = "insert a line element";
			// 
			// tbtnPath
			// 
			this.tbtnPath.ImageIndex = 10;
			this.tbtnPath.ToolTipText = "insert a path element";
			// 
			// tbtnPolygon
			// 
			this.tbtnPolygon.ImageIndex = 11;
			this.tbtnPolygon.ToolTipText = "insert a polygon element";
			// 
			// tbtnImage
			// 
			this.tbtnImage.ImageIndex = 23;
			this.tbtnImage.ToolTipText = "insert an image element";
			// 
			// sep2
			// 
			this.sep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbtnCut
			// 
			this.tbtnCut.ImageIndex = 12;
			this.tbtnCut.ToolTipText = "cut";
			// 
			// tbtnCopy
			// 
			this.tbtnCopy.ImageIndex = 13;
			this.tbtnCopy.ToolTipText = "copy";
			// 
			// tbtnPaste
			// 
			this.tbtnPaste.ImageIndex = 14;
			this.tbtnPaste.ToolTipText = "paste";
			// 
			// tbtnDelete
			// 
			this.tbtnDelete.ImageIndex = 15;
			this.tbtnDelete.ToolTipText = "delete";
			// 
			// tbtnPositionUp
			// 
			this.tbtnPositionUp.ImageIndex = 16;
			this.tbtnPositionUp.ToolTipText = "move the element up";
			// 
			// tbtnPositionDown
			// 
			this.tbtnPositionDown.ImageIndex = 17;
			this.tbtnPositionDown.ToolTipText = "move the element down";
			// 
			// tbtnLevelUp
			// 
			this.tbtnLevelUp.ImageIndex = 18;
			this.tbtnLevelUp.ToolTipText = "move the element one level up";
			// 
			// sep3
			// 
			this.sep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbtnAbout
			// 
			this.tbtnAbout.ImageIndex = 21;
			this.tbtnAbout.ToolTipText = "about";
			// 
			// tbtnExit
			// 
			this.tbtnExit.ImageIndex = 22;
			this.tbtnExit.ToolTipText = "exit SvgPad";
			// 
			// imgTB
			// 
			this.imgTB.ImageSize = new System.Drawing.Size(20, 20);
			this.imgTB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTB.ImageStream")));
			this.imgTB.TransparentColor = System.Drawing.Color.Red;
			// 
			// mnuSvgEdit
			// 
			this.mnuSvgEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuInsert,
																					   this.menuEdit2,
																					   this.menuCut,
																					   this.menuCopy,
																					   this.menuPaste,
																					   this.menuDelete,
																					   this.menuMoveUp,
																					   this.menuMoveDown});
			// 
			// menuInsert
			// 
			this.menuInsert.Index = 0;
			this.menuInsert.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuEdit_group,
																					   this.menuEdit_description,
																					   this.menuEdit_text,
																					   this.menuEdit_rect,
																					   this.menuEdit_circle,
																					   this.menuEdit_ellipse,
																					   this.menuEdit_line,
																					   this.menuEdit_path,
																					   this.menuEdit_polygon,
																					   this.menuEdit_image});
			this.menuInsert.Text = "insert";
			// 
			// menuEdit_group
			// 
			this.menuEdit_group.Index = 0;
			this.menuEdit_group.Text = "group";
			this.menuEdit_group.Click += new System.EventHandler(this.menuEdit_group_Click);
			// 
			// menuEdit_description
			// 
			this.menuEdit_description.Index = 1;
			this.menuEdit_description.Text = "description";
			this.menuEdit_description.Click += new System.EventHandler(this.menuEdit_description_Click);
			// 
			// menuEdit_text
			// 
			this.menuEdit_text.Index = 2;
			this.menuEdit_text.Text = "text";
			this.menuEdit_text.Click += new System.EventHandler(this.menuEdit_text_Click);
			// 
			// menuEdit_rect
			// 
			this.menuEdit_rect.Index = 3;
			this.menuEdit_rect.Text = "rect";
			this.menuEdit_rect.Click += new System.EventHandler(this.menuEdit_rect_Click);
			// 
			// menuEdit_circle
			// 
			this.menuEdit_circle.Index = 4;
			this.menuEdit_circle.Text = "circle";
			this.menuEdit_circle.Click += new System.EventHandler(this.menuEdit_circle_Click);
			// 
			// menuEdit_ellipse
			// 
			this.menuEdit_ellipse.Index = 5;
			this.menuEdit_ellipse.Text = "ellipse";
			this.menuEdit_ellipse.Click += new System.EventHandler(this.menuEdit_ellipse_Click);
			// 
			// menuEdit_line
			// 
			this.menuEdit_line.Index = 6;
			this.menuEdit_line.Text = "line";
			this.menuEdit_line.Click += new System.EventHandler(this.menuEdit_line_Click);
			// 
			// menuEdit_path
			// 
			this.menuEdit_path.Index = 7;
			this.menuEdit_path.Text = "path";
			this.menuEdit_path.Click += new System.EventHandler(this.menuEdit_path_Click);
			// 
			// menuEdit_polygon
			// 
			this.menuEdit_polygon.Index = 8;
			this.menuEdit_polygon.Text = "polygon";
			this.menuEdit_polygon.Click += new System.EventHandler(this.menuEdit_polygon_Click);
			// 
			// menuEdit_image
			// 
			this.menuEdit_image.Index = 9;
			this.menuEdit_image.Text = "image";
			this.menuEdit_image.Click += new System.EventHandler(this.menuEdit_image_Click);
			// 
			// menuEdit2
			// 
			this.menuEdit2.Index = 1;
			this.menuEdit2.Text = "-";
			// 
			// menuCut
			// 
			this.menuCut.Index = 2;
			this.menuCut.Text = "cut";
			this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// menuCopy
			// 
			this.menuCopy.Index = 3;
			this.menuCopy.Text = "copy";
			this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// menuPaste
			// 
			this.menuPaste.Index = 4;
			this.menuPaste.Text = "paste";
			this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// menuDelete
			// 
			this.menuDelete.Index = 5;
			this.menuDelete.Text = "delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			// 
			// menuMoveUp
			// 
			this.menuMoveUp.Index = 6;
			this.menuMoveUp.Text = "move up";
			this.menuMoveUp.Click += new System.EventHandler(this.menuMoveUp_Click);
			// 
			// menuMoveDown
			// 
			this.menuMoveDown.Index = 7;
			this.menuMoveDown.Text = "move down";
			this.menuMoveDown.Click += new System.EventHandler(this.menuMoveDown_Click);
			// 
			// sb
			// 
			this.sb.Location = new System.Drawing.Point(5, 535);
			this.sb.Name = "sb";
			this.sb.Size = new System.Drawing.Size(782, 22);
			this.sb.TabIndex = 1;
			this.sb.Text = "SVG Pad... ready";
			// 
			// img
			// 
			this.img.ImageSize = new System.Drawing.Size(20, 20);
			this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
			this.img.TransparentColor = System.Drawing.Color.Red;
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.panelContent);
			this.panelMain.Controls.Add(this.splitter1);
			this.panelMain.Controls.Add(this.tv);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.DockPadding.All = 5;
			this.panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelMain.Location = new System.Drawing.Point(5, 37);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(782, 498);
			this.panelMain.TabIndex = 9;
			// 
			// panelContent
			// 
			this.panelContent.Controls.Add(this.panelList);
			this.panelContent.Controls.Add(this.txtXML);
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(203, 5);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(574, 488);
			this.panelContent.TabIndex = 9;
			// 
			// panelList
			// 
			this.panelList.Controls.Add(this.pgrid);
			this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelList.DockPadding.Bottom = 5;
			this.panelList.Location = new System.Drawing.Point(0, 0);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(574, 432);
			this.panelList.TabIndex = 9;
			// 
			// pgrid
			// 
			this.pgrid.CommandsVisibleIfAvailable = true;
			this.pgrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgrid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pgrid.LargeButtons = false;
			this.pgrid.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pgrid.Location = new System.Drawing.Point(0, 0);
			this.pgrid.Name = "pgrid";
			this.pgrid.Size = new System.Drawing.Size(574, 427);
			this.pgrid.TabIndex = 13;
			this.pgrid.Text = "propertyGrid1";
			this.pgrid.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pgrid.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pgrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrid_PropertyValueChanged);
			// 
			// txtXML
			// 
			this.txtXML.AccessibleDescription = "";
			this.txtXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtXML.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txtXML.Location = new System.Drawing.Point(0, 432);
			this.txtXML.Multiline = true;
			this.txtXML.Name = "txtXML";
			this.txtXML.ReadOnly = true;
			this.txtXML.Size = new System.Drawing.Size(574, 56);
			this.txtXML.TabIndex = 7;
			this.txtXML.Text = "";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(200, 5);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 488);
			this.splitter1.TabIndex = 6;
			this.splitter1.TabStop = false;
			// 
			// tv
			// 
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tv.ContextMenu = this.mnuSvgEdit;
			this.tv.Dock = System.Windows.Forms.DockStyle.Left;
			this.tv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tv.HideSelection = false;
			this.tv.ImageList = this.img;
			this.tv.Location = new System.Drawing.Point(5, 5);
			this.tv.Name = "tv";
			this.tv.Size = new System.Drawing.Size(195, 488);
			this.tv.TabIndex = 5;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// imgListView
			// 
			this.imgListView.ImageSize = new System.Drawing.Size(16, 16);
			this.imgListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListView.ImageStream")));
			this.imgListView.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// saveFile
			// 
			this.saveFile.DefaultExt = "svg";
			this.saveFile.Filter = "SVG Files|*.svg|All files|*.*";
			this.saveFile.Title = "SVG Pad :: save";
			// 
			// openFile
			// 
			this.openFile.Filter = "SVG Files|*.svg|All files|*.*";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 562);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.sb);
			this.Controls.Add(this.tbMain);
			this.DockPadding.All = 5;
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ":: SVG Pad ::";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.panelMain.ResumeLayout(false);
			this.panelContent.ResumeLayout(false);
			this.panelList.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		// --- FORM EVENTS
		private void frmMain_Load(object sender, System.EventArgs e)
		{
		
		}

		private void frmMain_Closing(object sender, CancelEventArgs e)
		{
			if (MessageBox.Show ("Exit?", "SVGPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
			{
				Application.Exit();
			}
			else
			{
				e.Cancel = true;
			}
		}
		// ---

		// --- MAIN TOOLBAR EVENTS
		private void tbMain_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(tbMain.Buttons.IndexOf(e.Button))
			{
				case 0: // new
					NewTree();

					break; 

				case 1: // open
					LoadTree();

					break; 

				case 2: // save
					if ( IsDocPresent() )
					{
						SaveSvgDocument();
					}
					break; 

				case 3: // preview
					if ( IsDocPresent() )
					{
						SaveSvgDocument();

						if ( File.Exists(m_sFileName) )
						{
							System.Diagnostics.Process.Start(m_sFileName);
						}
					}
					break;

				case 5: // description element
					AddDescription();
					break; 

				case 6: // text element
					AddText();
					break; 

				case 7: // group element
					AddGroup();
					break; 

				case 8: // rect element
					AddRect();
					break; 

				case 9: // circle element
					AddCircle();
					break; 

				case 10: // ellipse element
					AddEllipse();
					break;
 
				case 11: // line element
					AddLine();
					break; 

				case 12: // path element
					AddPath();
					break; 

				case 13: // polygon element
					AddPolygon();
					break; 

				case 14: // image element
					AddImage();
					break; 

				case 16: 
					Cut();
					break;

				case 17:
					Copy();
					break;

				case 18:
					Paste();
					break;

				case 19:
					Delete();
					break;

				case 20:
					ElementUp();
					break;

				case 21:
					ElementDown();
					break;

				case 22:
					LevelUp();
					break;

				case 24: // about
					frmAbout about = new frmAbout();
					about.ShowDialog();
					break;

				case 25: // exit
					if (MessageBox.Show ("Exit?", "SVGPad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
					{
						Application.Exit();
					}
					break;
			}
		}
		// ---

		// --- MENU SVG ELEMENTS
		private void menuEdit_group_Click(object sender, System.EventArgs e)
		{
			AddGroup();
		}
		private void menuEdit_description_Click(object sender, System.EventArgs e)
		{
			AddDescription();
		}
		private void menuEdit_text_Click(object sender, System.EventArgs e)
		{
			AddText();
		}
		private void menuEdit_rect_Click(object sender, System.EventArgs e)
		{
			AddRect();
		}
		private void menuEdit_circle_Click(object sender, System.EventArgs e)
		{
			AddCircle();
		}
		private void menuEdit_ellipse_Click(object sender, System.EventArgs e)
		{
			AddEllipse();
		}
		private void menuEdit_line_Click(object sender, System.EventArgs e)
		{
			AddLine();
		}
		private void menuEdit_path_Click(object sender, System.EventArgs e)
		{
			AddPath();
		}
		private void menuEdit_polygon_Click(object sender, System.EventArgs e)
		{
			AddPolygon();
		}
		private void menuEdit_image_Click(object sender, System.EventArgs e)
		{
			AddImage();
		}
		// --- END MENU SVG ELEMENTS

		// --- MENU EDIT
		private void menuCut_Click(object sender, System.EventArgs e)
		{
			Cut();
		}

		private void menuCopy_Click(object sender, System.EventArgs e)
		{
			Copy();
		}

		private void menuPaste_Click(object sender, System.EventArgs e)
		{
			Paste();
		}

		private void menuDelete_Click(object sender, System.EventArgs e)
		{
			Delete();
		}

		private void menuMoveUp_Click(object sender, System.EventArgs e)
		{
			ElementUp();
		}

		private void menuMoveDown_Click(object sender, System.EventArgs e)
		{
			ElementDown();
		}
		// --- END MENU EDIT

		// --- TREE VIEW EVENTS
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			pgrid.SelectedObject = ele;
			
			// fill XML text
			txtXML.Text= ele.GetTagXml();
		}
		// ---

		// --- PROPERTY GRID EVENTS
		private void pgrid_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			// fill XML text
			txtXML.Text= ele.GetTagXml();

			// if the Id changes the tree node has to be refreshed
			if ( e.ChangedItem.Label == "Id" )
			{
				string sNodeName = ele.getElementName();
				string sId;
				sId = ele.Id;
			
				if ( sId != "" )
				{
					sNodeName += "(";
					sNodeName += sId;
					sNodeName += ")";
				}

				TreeNode nod = FindNodeByTag(null, ele.getInternalId().ToString());
				if ( nod != null )
				{
					nod.Text = sNodeName;
				}
			}
		}
		// ---

		// --- PRIVATE METHODS
		private bool IsDocPresent()
		{
			if ( m_svg == null )
			{
				MessageBox.Show ("No document has been created", "SVGPad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			else
			{
				return true;
			}
		}

		private void AddGroup()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgGroup grp = m_svg.AddGroup(ele);
			AddNodeToTree(grp);
		}

		private void AddDescription()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgDesc desc = m_svg.AddDesc(ele);
			AddNodeToTree(desc);
		}

		private void AddText()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgText txt = m_svg.AddText(ele);
			AddNodeToTree(txt);
		}

		private void AddRect()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgRect rect = m_svg.AddRect(ele);
			AddNodeToTree(rect);
		}

		private void AddCircle()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgCircle circle = m_svg.AddCircle(ele);
			AddNodeToTree(circle);
		}

		private void AddEllipse()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgEllipse ellipse = m_svg.AddEllipse(ele);
			AddNodeToTree(ellipse);
		}

		private void AddLine()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgLine line = m_svg.AddLine(ele);
			AddNodeToTree(line);
		}

		private void AddPath()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgPath path = m_svg.AddPath(ele);
			AddNodeToTree(path);
		}

		private void AddPolygon()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgPolygon poly = m_svg.AddPolygon(ele);
			AddNodeToTree(poly);
		}

		private void AddImage()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			SvgImage img = m_svg.AddImage(ele);
			AddNodeToTree(img);
		}

		private void Cut()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			m_eleClipboard = ele;

			// delete the current element
			Delete();
		}

		private void Copy()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			m_eleClipboard = ele;
		}

		private void Paste()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			if ( m_eleClipboard == null )
			{
				return;
			}

			SvgElement eleNew = m_svg.CloneElement(ele, m_eleClipboard);

			AddNodeToTree(eleNew);
		}

		private void Delete()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			if ( m_svg.DeleteElement(ele) )
			{
				// delete the element from the tree

				TreeNode nodToDelete = tv.SelectedNode;

				tv.SelectedNode = tv.SelectedNode.Parent;
				tv.SelectedNode.Nodes.Remove(nodToDelete);
			}
		}

		private void ElementUp()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			if ( m_svg.ElementPositionUp(ele) )
			{
				// remove the node from the tree
				TreeNode nodToDelete = tv.SelectedNode;

				tv.SelectedNode = tv.SelectedNode.Parent;
				tv.SelectedNode.Nodes.Remove(nodToDelete);

				// add the new node
				AddNodeToTree(ele.getParent(), ele, ele.getNext());
			}
		}

		private void ElementDown()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			if ( m_svg.ElementPositionDown(ele) )
			{
				// remove the node from the tree
				TreeNode nodToDelete = tv.SelectedNode;

				tv.SelectedNode = tv.SelectedNode.Parent;
				tv.SelectedNode.Nodes.Remove(nodToDelete);

				// add the new node
				AddNodeToTree(ele.getParent(), ele, ele.getNext());
			}
		}

		private void LevelUp()
		{
			if ( !IsDocPresent() )
			{
				return;
			}

			SvgElement ele = GetCurrentSvgElement();
			if ( ele == null )
			{
				return;
			}

			if ( m_svg.ElementLevelUp(ele) )
			{
				// remove the node from the tree
				TreeNode nodToDelete = tv.SelectedNode;

				tv.SelectedNode = tv.SelectedNode.Parent;
				tv.SelectedNode.Nodes.Remove(nodToDelete);

				// add the new node
				AddNodeToTree(ele.getParent(), ele, ele.getNext());
			}
		}
		
		private void ResetTree()
		{
			m_sFileName = "";

			m_lvstate = new Hashtable();

			txtXML.Text = "";
			tv.Nodes.Clear();
		
			m_svg = new SvgDoc();
		}

		// delete the current tree content (if any) and
		// create a new empty svg document
		private void NewTree()
		{
			ResetTree();
			sb.Text = "[NEW] unsaved document...";

			SvgElement ele = m_svg.CreateNewDocument();

			AddNodeToTree(ele);
		}

		// load the tree from an svg file
		private void LoadTree()
		{
			if (openFile.ShowDialog(this) != DialogResult.OK)
			{
				return;
			}

			if ( !File.Exists(openFile.FileName)) 
			{
				MessageBox.Show ("The file does not exists!", "SVGPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			ResetTree();

			m_sFileName = openFile.FileName;

			if ( !m_svg.LoadFromFile(m_sFileName) || m_svg.GetSvgRoot() == null )
			{
				MessageBox.Show ("The file is not a valid Svg!", "SVGPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			sb.Text = m_sFileName;

			AddNodeToTree(null, m_svg.GetSvgRoot(), null);
		}

		private void SaveSvgDocument()
		{
			if ( m_sFileName == "" )
			{
				if(saveFile.ShowDialog(this) != DialogResult.OK)
				{
					return;
				}

				m_sFileName = saveFile.FileName;
			}

			if (!m_svg.SaveToFile(m_sFileName))
			{
				MessageBox.Show ("Cannot create file!", "SVGPad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				m_sFileName = "";
				return;
			}

			sb.Text = m_sFileName;
		}

		// get the SvgElement associated with the current selected node
		// in the tree view
		private SvgElement GetCurrentSvgElement()
		{
			TreeNode nod = tv.SelectedNode;
			if (nod == null)
			{
				return null;
			}

			// the tree view node tag is the SvgElement getInternalId()
			SvgElement ele = m_svg.GetSvgElement((int) nod.Tag);

			return ele;
		}

		// find a node in the tree view subtree (starting from nodParent)
		// if nodParent is null the search process starts from the root
		// the tag is the SvgElement getInternalId()
		private TreeNode FindNodeByTag(TreeNode nodParent, string sTag)
		{
			if ( nodParent == null )
			{
				// start from the root
				nodParent = tv.Nodes[0];
			}
			if ( nodParent == null )
			{
				// the tree is empty
				return null;
			}

			if ( nodParent.Tag.ToString() == sTag )
			{
				return nodParent;
			}

			foreach (TreeNode nod in nodParent.Nodes)
			{
				TreeNode nodToRet = FindNodeByTag(nod, sTag);
				if ( nodToRet != null )
				{
					return nodToRet;
				}
			}

			return null;
		}

		// add a new node to the tree related to the SvgElement ele
		// the node is added as a new child of the selected node
		private void AddNodeToTree(SvgElement ele)
		{
			if ( ele == null )
			{
				return;
			}

			SvgElement parent = GetCurrentSvgElement();
			AddNodeToTree(parent, ele, null);
		}

		// add a new node to the tree related to the SvgElement ele
		// the node is added as a new child of the node related to the
		// SvgElement parent
		// if eleBefore is not null the child is positionated just after it
		private void AddNodeToTree(SvgElement eleParent, 
			                       SvgElement eleToAdd, 
			                       SvgElement eleBefore)
		{
			if ( eleToAdd == null )
			{
				return;
			}

			string sNodeName = eleToAdd.getElementName();
			string sId;
			sId = eleToAdd.Id;

			
			if ( sId != "" )
			{
				sNodeName += "(";
				sNodeName += sId;
				sNodeName += ")";
			}
			TreeNode nod = new TreeNode(sNodeName, 0, 0);
			nod.Tag = eleToAdd.getInternalId();
			
			TreeNode nodParent = null;
			TreeNode nodBefore = null;
			
			if ( eleParent != null )
			{
				nodParent = FindNodeByTag(null, eleParent.getInternalId().ToString());
			}

			if ( eleBefore != null )
			{
				nodBefore = FindNodeByTag(nodParent, eleBefore.getInternalId().ToString());
			}

			if ( nodParent == null )
			{
				if ( nodBefore == null )
				{
					tv.Nodes.Add(nod);
				}
				else
				{
					tv.Nodes.Insert(nodBefore.Index, nod);
				}
			}
			else
			{
				if ( nodBefore == null )
				{
					nodParent.Nodes.Add(nod);
				}
				else
				{
					nodParent.Nodes.Insert(nodBefore.Index, nod);
				}
			}

			nod.ImageIndex = (int)eleToAdd.getElementType();
			nod.SelectedImageIndex = nod.ImageIndex;
			nod.Expand();

			if ( eleToAdd.getChild() != null )
			{
				AddNodeToTree(eleToAdd, eleToAdd.getChild(), null);
				
				SvgElement nxt = eleToAdd.getChild().getNext();
				while ( nxt != null )
				{
					AddNodeToTree(eleToAdd, nxt, null);
					nxt = nxt.getNext();
				}
			}
			tv.SelectedNode = nod;
		}
		// ---
	}
}
