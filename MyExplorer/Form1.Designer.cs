namespace MyExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readOnly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 4;
            this.treeView1.Size = new System.Drawing.Size(233, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "winxp_ico_shell32_dll-000.png");
            this.imageList2.Images.SetKeyName(1, "winxp_ico_shell32_dll-001.png");
            this.imageList2.Images.SetKeyName(2, "winxp_ico_shell32_dll-002.png");
            this.imageList2.Images.SetKeyName(3, "winxp_ico_shell32_dll-003.png");
            this.imageList2.Images.SetKeyName(4, "winxp_ico_shell32_dll-004.png");
            this.imageList2.Images.SetKeyName(5, "winxp_ico_shell32_dll-005.png");
            this.imageList2.Images.SetKeyName(6, "winxp_ico_shell32_dll-006.png");
            this.imageList2.Images.SetKeyName(7, "winxp_ico_shell32_dll-007.png");
            this.imageList2.Images.SetKeyName(8, "winxp_ico_shell32_dll-008.png");
            this.imageList2.Images.SetKeyName(9, "winxp_ico_shell32_dll-009.png");
            this.imageList2.Images.SetKeyName(10, "winxp_ico_shell32_dll-010.png");
            this.imageList2.Images.SetKeyName(11, "winxp_ico_shell32_dll-011.png");
            this.imageList2.Images.SetKeyName(12, "winxp_ico_shell32_dll-012.png");
            this.imageList2.Images.SetKeyName(13, "winxp_ico_shell32_dll-013.png");
            this.imageList2.Images.SetKeyName(14, "winxp_ico_shell32_dll-014.png");
            this.imageList2.Images.SetKeyName(15, "winxp_ico_shell32_dll-015.png");
            this.imageList2.Images.SetKeyName(16, "winxp_ico_shell32_dll-016.png");
            this.imageList2.Images.SetKeyName(17, "winxp_ico_shell32_dll-017.png");
            this.imageList2.Images.SetKeyName(18, "winxp_ico_shell32_dll-018.png");
            this.imageList2.Images.SetKeyName(19, "winxp_ico_shell32_dll-019.png");
            this.imageList2.Images.SetKeyName(20, "winxp_ico_shell32_dll-020.png");
            this.imageList2.Images.SetKeyName(21, "winxp_ico_shell32_dll-021.png");
            this.imageList2.Images.SetKeyName(22, "winxp_ico_shell32_dll-022.png");
            this.imageList2.Images.SetKeyName(23, "winxp_ico_shell32_dll-023.png");
            this.imageList2.Images.SetKeyName(24, "winxp_ico_shell32_dll-024.png");
            this.imageList2.Images.SetKeyName(25, "winxp_ico_shell32_dll-025.png");
            this.imageList2.Images.SetKeyName(26, "winxp_ico_shell32_dll-026.png");
            this.imageList2.Images.SetKeyName(27, "winxp_ico_shell32_dll-027.png");
            this.imageList2.Images.SetKeyName(28, "winxp_ico_shell32_dll-028.png");
            this.imageList2.Images.SetKeyName(29, "winxp_ico_shell32_dll-029.png");
            this.imageList2.Images.SetKeyName(30, "winxp_ico_shell32_dll-030.png");
            this.imageList2.Images.SetKeyName(31, "winxp_ico_shell32_dll-031.png");
            this.imageList2.Images.SetKeyName(32, "winxp_ico_shell32_dll-032.png");
            this.imageList2.Images.SetKeyName(33, "winxp_ico_shell32_dll-033.png");
            this.imageList2.Images.SetKeyName(34, "winxp_ico_shell32_dll-034.png");
            this.imageList2.Images.SetKeyName(35, "winxp_ico_shell32_dll-035.png");
            this.imageList2.Images.SetKeyName(36, "winxp_ico_shell32_dll-036.png");
            this.imageList2.Images.SetKeyName(37, "winxp_ico_shell32_dll-037.png");
            this.imageList2.Images.SetKeyName(38, "winxp_ico_shell32_dll-038.png");
            this.imageList2.Images.SetKeyName(39, "winxp_ico_shell32_dll-039.png");
            this.imageList2.Images.SetKeyName(40, "winxp_ico_shell32_dll-040.png");
            this.imageList2.Images.SetKeyName(41, "winxp_ico_shell32_dll-041.png");
            this.imageList2.Images.SetKeyName(42, "winxp_ico_shell32_dll-042.png");
            this.imageList2.Images.SetKeyName(43, "winxp_ico_shell32_dll-043.png");
            this.imageList2.Images.SetKeyName(44, "winxp_ico_shell32_dll-044.png");
            this.imageList2.Images.SetKeyName(45, "winxp_ico_shell32_dll-045.png");
            this.imageList2.Images.SetKeyName(46, "winxp_ico_shell32_dll-046.png");
            this.imageList2.Images.SetKeyName(47, "winxp_ico_shell32_dll-047.png");
            this.imageList2.Images.SetKeyName(48, "winxp_ico_shell32_dll-048.png");
            this.imageList2.Images.SetKeyName(49, "winxp_ico_shell32_dll-049.png");
            this.imageList2.Images.SetKeyName(50, "winxp_ico_shell32_dll-050.png");
            this.imageList2.Images.SetKeyName(51, "winxp_ico_shell32_dll-051.png");
            this.imageList2.Images.SetKeyName(52, "winxp_ico_shell32_dll-052.png");
            this.imageList2.Images.SetKeyName(53, "winxp_ico_shell32_dll-053.png");
            this.imageList2.Images.SetKeyName(54, "winxp_ico_shell32_dll-054.png");
            this.imageList2.Images.SetKeyName(55, "winxp_ico_shell32_dll-055.png");
            this.imageList2.Images.SetKeyName(56, "winxp_ico_shell32_dll-056.png");
            this.imageList2.Images.SetKeyName(57, "winxp_ico_shell32_dll-057.png");
            this.imageList2.Images.SetKeyName(58, "winxp_ico_shell32_dll-058.png");
            this.imageList2.Images.SetKeyName(59, "winxp_ico_shell32_dll-059.png");
            this.imageList2.Images.SetKeyName(60, "winxp_ico_shell32_dll-060.png");
            this.imageList2.Images.SetKeyName(61, "winxp_ico_shell32_dll-061.png");
            this.imageList2.Images.SetKeyName(62, "winxp_ico_shell32_dll-062.png");
            this.imageList2.Images.SetKeyName(63, "winxp_ico_shell32_dll-063.png");
            this.imageList2.Images.SetKeyName(64, "winxp_ico_shell32_dll-064.png");
            this.imageList2.Images.SetKeyName(65, "winxp_ico_shell32_dll-065.png");
            this.imageList2.Images.SetKeyName(66, "winxp_ico_shell32_dll-066.png");
            this.imageList2.Images.SetKeyName(67, "winxp_ico_shell32_dll-067.png");
            this.imageList2.Images.SetKeyName(68, "winxp_ico_shell32_dll-068.png");
            this.imageList2.Images.SetKeyName(69, "winxp_ico_shell32_dll-069.png");
            this.imageList2.Images.SetKeyName(70, "winxp_ico_shell32_dll-070.png");
            this.imageList2.Images.SetKeyName(71, "winxp_ico_shell32_dll-071.png");
            this.imageList2.Images.SetKeyName(72, "winxp_ico_shell32_dll-072.png");
            this.imageList2.Images.SetKeyName(73, "winxp_ico_shell32_dll-073.png");
            this.imageList2.Images.SetKeyName(74, "winxp_ico_shell32_dll-074.png");
            this.imageList2.Images.SetKeyName(75, "winxp_ico_shell32_dll-075.png");
            this.imageList2.Images.SetKeyName(76, "winxp_ico_shell32_dll-076.png");
            this.imageList2.Images.SetKeyName(77, "winxp_ico_shell32_dll-077.png");
            this.imageList2.Images.SetKeyName(78, "winxp_ico_shell32_dll-078.png");
            this.imageList2.Images.SetKeyName(79, "winxp_ico_shell32_dll-079.png");
            this.imageList2.Images.SetKeyName(80, "winxp_ico_shell32_dll-080.png");
            this.imageList2.Images.SetKeyName(81, "winxp_ico_shell32_dll-081.png");
            this.imageList2.Images.SetKeyName(82, "winxp_ico_shell32_dll-082.png");
            this.imageList2.Images.SetKeyName(83, "winxp_ico_shell32_dll-083.png");
            this.imageList2.Images.SetKeyName(84, "winxp_ico_shell32_dll-084.png");
            this.imageList2.Images.SetKeyName(85, "winxp_ico_shell32_dll-085.png");
            this.imageList2.Images.SetKeyName(86, "winxp_ico_shell32_dll-086.png");
            this.imageList2.Images.SetKeyName(87, "winxp_ico_shell32_dll-087.png");
            this.imageList2.Images.SetKeyName(88, "winxp_ico_shell32_dll-088.png");
            this.imageList2.Images.SetKeyName(89, "winxp_ico_shell32_dll-089.png");
            this.imageList2.Images.SetKeyName(90, "winxp_ico_shell32_dll-090.png");
            this.imageList2.Images.SetKeyName(91, "winxp_ico_shell32_dll-091.png");
            this.imageList2.Images.SetKeyName(92, "winxp_ico_shell32_dll-092.png");
            this.imageList2.Images.SetKeyName(93, "winxp_ico_shell32_dll-093.png");
            this.imageList2.Images.SetKeyName(94, "winxp_ico_shell32_dll-094.png");
            this.imageList2.Images.SetKeyName(95, "winxp_ico_shell32_dll-095.png");
            this.imageList2.Images.SetKeyName(96, "winxp_ico_shell32_dll-096.png");
            this.imageList2.Images.SetKeyName(97, "winxp_ico_shell32_dll-097.png");
            this.imageList2.Images.SetKeyName(98, "winxp_ico_shell32_dll-098.png");
            this.imageList2.Images.SetKeyName(99, "winxp_ico_shell32_dll-099.png");
            this.imageList2.Images.SetKeyName(100, "winxp_ico_shell32_dll-100.png");
            this.imageList2.Images.SetKeyName(101, "winxp_ico_shell32_dll-101.png");
            this.imageList2.Images.SetKeyName(102, "winxp_ico_shell32_dll-102.png");
            this.imageList2.Images.SetKeyName(103, "winxp_ico_shell32_dll-103.png");
            this.imageList2.Images.SetKeyName(104, "winxp_ico_shell32_dll-104.png");
            this.imageList2.Images.SetKeyName(105, "winxp_ico_shell32_dll-105.png");
            this.imageList2.Images.SetKeyName(106, "winxp_ico_shell32_dll-106.png");
            this.imageList2.Images.SetKeyName(107, "winxp_ico_shell32_dll-107.png");
            this.imageList2.Images.SetKeyName(108, "winxp_ico_shell32_dll-108.png");
            this.imageList2.Images.SetKeyName(109, "winxp_ico_shell32_dll-109.png");
            this.imageList2.Images.SetKeyName(110, "winxp_ico_shell32_dll-110.png");
            this.imageList2.Images.SetKeyName(111, "winxp_ico_shell32_dll-111.png");
            this.imageList2.Images.SetKeyName(112, "winxp_ico_shell32_dll-112.png");
            this.imageList2.Images.SetKeyName(113, "winxp_ico_shell32_dll-113.png");
            this.imageList2.Images.SetKeyName(114, "winxp_ico_shell32_dll-114.png");
            this.imageList2.Images.SetKeyName(115, "winxp_ico_shell32_dll-115.png");
            this.imageList2.Images.SetKeyName(116, "winxp_ico_shell32_dll-116.png");
            this.imageList2.Images.SetKeyName(117, "winxp_ico_shell32_dll-117.png");
            this.imageList2.Images.SetKeyName(118, "winxp_ico_shell32_dll-118.png");
            this.imageList2.Images.SetKeyName(119, "winxp_ico_shell32_dll-119.png");
            this.imageList2.Images.SetKeyName(120, "winxp_ico_shell32_dll-120.png");
            this.imageList2.Images.SetKeyName(121, "winxp_ico_shell32_dll-121.png");
            this.imageList2.Images.SetKeyName(122, "winxp_ico_shell32_dll-122.png");
            this.imageList2.Images.SetKeyName(123, "winxp_ico_shell32_dll-123.png");
            this.imageList2.Images.SetKeyName(124, "winxp_ico_shell32_dll-124.png");
            this.imageList2.Images.SetKeyName(125, "winxp_ico_shell32_dll-125.png");
            this.imageList2.Images.SetKeyName(126, "winxp_ico_shell32_dll-126.png");
            this.imageList2.Images.SetKeyName(127, "winxp_ico_shell32_dll-127.png");
            this.imageList2.Images.SetKeyName(128, "winxp_ico_shell32_dll-128.png");
            this.imageList2.Images.SetKeyName(129, "winxp_ico_shell32_dll-129.png");
            this.imageList2.Images.SetKeyName(130, "winxp_ico_shell32_dll-130.png");
            this.imageList2.Images.SetKeyName(131, "winxp_ico_shell32_dll-131.png");
            this.imageList2.Images.SetKeyName(132, "winxp_ico_shell32_dll-132.png");
            this.imageList2.Images.SetKeyName(133, "winxp_ico_shell32_dll-133.png");
            this.imageList2.Images.SetKeyName(134, "winxp_ico_shell32_dll-134.png");
            this.imageList2.Images.SetKeyName(135, "winxp_ico_shell32_dll-135.png");
            this.imageList2.Images.SetKeyName(136, "winxp_ico_shell32_dll-136.png");
            this.imageList2.Images.SetKeyName(137, "winxp_ico_shell32_dll-137.png");
            this.imageList2.Images.SetKeyName(138, "winxp_ico_shell32_dll-138.png");
            this.imageList2.Images.SetKeyName(139, "winxp_ico_shell32_dll-139.png");
            this.imageList2.Images.SetKeyName(140, "winxp_ico_shell32_dll-140.png");
            this.imageList2.Images.SetKeyName(141, "winxp_ico_shell32_dll-141.png");
            this.imageList2.Images.SetKeyName(142, "winxp_ico_shell32_dll-142.png");
            this.imageList2.Images.SetKeyName(143, "winxp_ico_shell32_dll-143.png");
            this.imageList2.Images.SetKeyName(144, "winxp_ico_shell32_dll-144.png");
            this.imageList2.Images.SetKeyName(145, "winxp_ico_shell32_dll-145.png");
            this.imageList2.Images.SetKeyName(146, "winxp_ico_shell32_dll-146.png");
            this.imageList2.Images.SetKeyName(147, "winxp_ico_shell32_dll-147.png");
            this.imageList2.Images.SetKeyName(148, "winxp_ico_shell32_dll-148.png");
            this.imageList2.Images.SetKeyName(149, "winxp_ico_shell32_dll-149.png");
            this.imageList2.Images.SetKeyName(150, "winxp_ico_shell32_dll-150.png");
            this.imageList2.Images.SetKeyName(151, "winxp_ico_shell32_dll-151.png");
            this.imageList2.Images.SetKeyName(152, "winxp_ico_shell32_dll-152.png");
            this.imageList2.Images.SetKeyName(153, "winxp_ico_shell32_dll-153.png");
            this.imageList2.Images.SetKeyName(154, "winxp_ico_shell32_dll-154.png");
            this.imageList2.Images.SetKeyName(155, "winxp_ico_shell32_dll-155.png");
            this.imageList2.Images.SetKeyName(156, "winxp_ico_shell32_dll-156.png");
            this.imageList2.Images.SetKeyName(157, "winxp_ico_shell32_dll-157.png");
            this.imageList2.Images.SetKeyName(158, "winxp_ico_shell32_dll-158.png");
            this.imageList2.Images.SetKeyName(159, "winxp_ico_shell32_dll-159.png");
            this.imageList2.Images.SetKeyName(160, "winxp_ico_shell32_dll-160.png");
            this.imageList2.Images.SetKeyName(161, "winxp_ico_shell32_dll-161.png");
            this.imageList2.Images.SetKeyName(162, "winxp_ico_shell32_dll-162.png");
            this.imageList2.Images.SetKeyName(163, "winxp_ico_shell32_dll-163.png");
            this.imageList2.Images.SetKeyName(164, "winxp_ico_shell32_dll-164.png");
            this.imageList2.Images.SetKeyName(165, "winxp_ico_shell32_dll-165.png");
            this.imageList2.Images.SetKeyName(166, "winxp_ico_shell32_dll-166.png");
            this.imageList2.Images.SetKeyName(167, "winxp_ico_shell32_dll-167.png");
            this.imageList2.Images.SetKeyName(168, "winxp_ico_shell32_dll-168.png");
            this.imageList2.Images.SetKeyName(169, "winxp_ico_shell32_dll-169.png");
            this.imageList2.Images.SetKeyName(170, "winxp_ico_shell32_dll-170.png");
            this.imageList2.Images.SetKeyName(171, "winxp_ico_shell32_dll-171.png");
            this.imageList2.Images.SetKeyName(172, "winxp_ico_shell32_dll-172.png");
            this.imageList2.Images.SetKeyName(173, "winxp_ico_shell32_dll-173.png");
            this.imageList2.Images.SetKeyName(174, "winxp_ico_shell32_dll-174.png");
            this.imageList2.Images.SetKeyName(175, "winxp_ico_shell32_dll-175.png");
            this.imageList2.Images.SetKeyName(176, "winxp_ico_shell32_dll-176.png");
            this.imageList2.Images.SetKeyName(177, "winxp_ico_shell32_dll-177.png");
            this.imageList2.Images.SetKeyName(178, "winxp_ico_shell32_dll-178.png");
            this.imageList2.Images.SetKeyName(179, "winxp_ico_shell32_dll-179.png");
            this.imageList2.Images.SetKeyName(180, "winxp_ico_shell32_dll-180.png");
            this.imageList2.Images.SetKeyName(181, "winxp_ico_shell32_dll-181.png");
            this.imageList2.Images.SetKeyName(182, "winxp_ico_shell32_dll-182.png");
            this.imageList2.Images.SetKeyName(183, "winxp_ico_shell32_dll-183.png");
            this.imageList2.Images.SetKeyName(184, "winxp_ico_shell32_dll-184.png");
            this.imageList2.Images.SetKeyName(185, "winxp_ico_shell32_dll-185.png");
            this.imageList2.Images.SetKeyName(186, "winxp_ico_shell32_dll-186.png");
            this.imageList2.Images.SetKeyName(187, "winxp_ico_shell32_dll-187.png");
            this.imageList2.Images.SetKeyName(188, "winxp_ico_shell32_dll-188.png");
            this.imageList2.Images.SetKeyName(189, "winxp_ico_shell32_dll-189.png");
            this.imageList2.Images.SetKeyName(190, "winxp_ico_shell32_dll-190.png");
            this.imageList2.Images.SetKeyName(191, "winxp_ico_shell32_dll-191.png");
            this.imageList2.Images.SetKeyName(192, "winxp_ico_shell32_dll-192.png");
            this.imageList2.Images.SetKeyName(193, "winxp_ico_shell32_dll-193.png");
            this.imageList2.Images.SetKeyName(194, "winxp_ico_shell32_dll-194.png");
            this.imageList2.Images.SetKeyName(195, "winxp_ico_shell32_dll-195.png");
            this.imageList2.Images.SetKeyName(196, "winxp_ico_shell32_dll-196.png");
            this.imageList2.Images.SetKeyName(197, "winxp_ico_shell32_dll-197.png");
            this.imageList2.Images.SetKeyName(198, "winxp_ico_shell32_dll-198.png");
            this.imageList2.Images.SetKeyName(199, "winxp_ico_shell32_dll-199.png");
            this.imageList2.Images.SetKeyName(200, "winxp_ico_shell32_dll-200.png");
            this.imageList2.Images.SetKeyName(201, "winxp_ico_shell32_dll-201.png");
            this.imageList2.Images.SetKeyName(202, "winxp_ico_shell32_dll-202.png");
            this.imageList2.Images.SetKeyName(203, "winxp_ico_shell32_dll-203.png");
            this.imageList2.Images.SetKeyName(204, "winxp_ico_shell32_dll-204.png");
            this.imageList2.Images.SetKeyName(205, "winxp_ico_shell32_dll-205.png");
            this.imageList2.Images.SetKeyName(206, "winxp_ico_shell32_dll-206.png");
            this.imageList2.Images.SetKeyName(207, "winxp_ico_shell32_dll-207.png");
            this.imageList2.Images.SetKeyName(208, "winxp_ico_shell32_dll-208.png");
            this.imageList2.Images.SetKeyName(209, "winxp_ico_shell32_dll-209.png");
            this.imageList2.Images.SetKeyName(210, "winxp_ico_shell32_dll-210.png");
            this.imageList2.Images.SetKeyName(211, "winxp_ico_shell32_dll-211.png");
            this.imageList2.Images.SetKeyName(212, "winxp_ico_shell32_dll-212.png");
            this.imageList2.Images.SetKeyName(213, "winxp_ico_shell32_dll-213.png");
            this.imageList2.Images.SetKeyName(214, "winxp_ico_shell32_dll-214.png");
            this.imageList2.Images.SetKeyName(215, "winxp_ico_shell32_dll-215.png");
            this.imageList2.Images.SetKeyName(216, "winxp_ico_shell32_dll-216.png");
            this.imageList2.Images.SetKeyName(217, "winxp_ico_shell32_dll-217.png");
            this.imageList2.Images.SetKeyName(218, "winxp_ico_shell32_dll-218.png");
            this.imageList2.Images.SetKeyName(219, "winxp_ico_shell32_dll-219.png");
            this.imageList2.Images.SetKeyName(220, "winxp_ico_shell32_dll-220.png");
            this.imageList2.Images.SetKeyName(221, "winxp_ico_shell32_dll-221.png");
            this.imageList2.Images.SetKeyName(222, "winxp_ico_shell32_dll-222.png");
            this.imageList2.Images.SetKeyName(223, "winxp_ico_shell32_dll-223.png");
            this.imageList2.Images.SetKeyName(224, "winxp_ico_shell32_dll-224.png");
            this.imageList2.Images.SetKeyName(225, "winxp_ico_shell32_dll-225.png");
            this.imageList2.Images.SetKeyName(226, "winxp_ico_shell32_dll-226.png");
            this.imageList2.Images.SetKeyName(227, "winxp_ico_shell32_dll-227.png");
            this.imageList2.Images.SetKeyName(228, "winxp_ico_shell32_dll-228.png");
            this.imageList2.Images.SetKeyName(229, "winxp_ico_shell32_dll-229.png");
            this.imageList2.Images.SetKeyName(230, "winxp_ico_shell32_dll-230.png");
            this.imageList2.Images.SetKeyName(231, "winxp_ico_shell32_dll-231.png");
            this.imageList2.Images.SetKeyName(232, "winxp_ico_shell32_dll-232.png");
            this.imageList2.Images.SetKeyName(233, "winxp_ico_shell32_dll-233.png");
            this.imageList2.Images.SetKeyName(234, "winxp_ico_shell32_dll-234.png");
            this.imageList2.Images.SetKeyName(235, "winxp_ico_shell32_dll-235.png");
            this.imageList2.Images.SetKeyName(236, "winxp_ico_shell32_dll-236.png");
            this.imageList2.Images.SetKeyName(237, "winxp_ico_shell32_dll-237.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "winxp_ico_shell32_dll-000.png");
            this.imageList1.Images.SetKeyName(1, "winxp_ico_shell32_dll-001.png");
            this.imageList1.Images.SetKeyName(2, "winxp_ico_shell32_dll-002.png");
            this.imageList1.Images.SetKeyName(3, "winxp_ico_shell32_dll-003.png");
            this.imageList1.Images.SetKeyName(4, "winxp_ico_shell32_dll-004.png");
            this.imageList1.Images.SetKeyName(5, "winxp_ico_shell32_dll-005.png");
            this.imageList1.Images.SetKeyName(6, "winxp_ico_shell32_dll-006.png");
            this.imageList1.Images.SetKeyName(7, "winxp_ico_shell32_dll-007.png");
            this.imageList1.Images.SetKeyName(8, "winxp_ico_shell32_dll-008.png");
            this.imageList1.Images.SetKeyName(9, "winxp_ico_shell32_dll-009.png");
            this.imageList1.Images.SetKeyName(10, "winxp_ico_shell32_dll-010.png");
            this.imageList1.Images.SetKeyName(11, "winxp_ico_shell32_dll-011.png");
            this.imageList1.Images.SetKeyName(12, "winxp_ico_shell32_dll-012.png");
            this.imageList1.Images.SetKeyName(13, "winxp_ico_shell32_dll-013.png");
            this.imageList1.Images.SetKeyName(14, "winxp_ico_shell32_dll-014.png");
            this.imageList1.Images.SetKeyName(15, "winxp_ico_shell32_dll-015.png");
            this.imageList1.Images.SetKeyName(16, "winxp_ico_shell32_dll-016.png");
            this.imageList1.Images.SetKeyName(17, "winxp_ico_shell32_dll-017.png");
            this.imageList1.Images.SetKeyName(18, "winxp_ico_shell32_dll-018.png");
            this.imageList1.Images.SetKeyName(19, "winxp_ico_shell32_dll-019.png");
            this.imageList1.Images.SetKeyName(20, "winxp_ico_shell32_dll-020.png");
            this.imageList1.Images.SetKeyName(21, "winxp_ico_shell32_dll-021.png");
            this.imageList1.Images.SetKeyName(22, "winxp_ico_shell32_dll-022.png");
            this.imageList1.Images.SetKeyName(23, "winxp_ico_shell32_dll-023.png");
            this.imageList1.Images.SetKeyName(24, "winxp_ico_shell32_dll-024.png");
            this.imageList1.Images.SetKeyName(25, "winxp_ico_shell32_dll-025.png");
            this.imageList1.Images.SetKeyName(26, "winxp_ico_shell32_dll-026.png");
            this.imageList1.Images.SetKeyName(27, "winxp_ico_shell32_dll-027.png");
            this.imageList1.Images.SetKeyName(28, "winxp_ico_shell32_dll-028.png");
            this.imageList1.Images.SetKeyName(29, "winxp_ico_shell32_dll-029.png");
            this.imageList1.Images.SetKeyName(30, "winxp_ico_shell32_dll-030.png");
            this.imageList1.Images.SetKeyName(31, "winxp_ico_shell32_dll-031.png");
            this.imageList1.Images.SetKeyName(32, "winxp_ico_shell32_dll-032.png");
            this.imageList1.Images.SetKeyName(33, "winxp_ico_shell32_dll-033.png");
            this.imageList1.Images.SetKeyName(34, "winxp_ico_shell32_dll-034.png");
            this.imageList1.Images.SetKeyName(35, "winxp_ico_shell32_dll-035.png");
            this.imageList1.Images.SetKeyName(36, "winxp_ico_shell32_dll-036.png");
            this.imageList1.Images.SetKeyName(37, "winxp_ico_shell32_dll-037.png");
            this.imageList1.Images.SetKeyName(38, "winxp_ico_shell32_dll-038.png");
            this.imageList1.Images.SetKeyName(39, "winxp_ico_shell32_dll-039.png");
            this.imageList1.Images.SetKeyName(40, "winxp_ico_shell32_dll-040.png");
            this.imageList1.Images.SetKeyName(41, "winxp_ico_shell32_dll-041.png");
            this.imageList1.Images.SetKeyName(42, "winxp_ico_shell32_dll-042.png");
            this.imageList1.Images.SetKeyName(43, "winxp_ico_shell32_dll-043.png");
            this.imageList1.Images.SetKeyName(44, "winxp_ico_shell32_dll-044.png");
            this.imageList1.Images.SetKeyName(45, "winxp_ico_shell32_dll-045.png");
            this.imageList1.Images.SetKeyName(46, "winxp_ico_shell32_dll-046.png");
            this.imageList1.Images.SetKeyName(47, "winxp_ico_shell32_dll-047.png");
            this.imageList1.Images.SetKeyName(48, "winxp_ico_shell32_dll-048.png");
            this.imageList1.Images.SetKeyName(49, "winxp_ico_shell32_dll-049.png");
            this.imageList1.Images.SetKeyName(50, "winxp_ico_shell32_dll-050.png");
            this.imageList1.Images.SetKeyName(51, "winxp_ico_shell32_dll-051.png");
            this.imageList1.Images.SetKeyName(52, "winxp_ico_shell32_dll-052.png");
            this.imageList1.Images.SetKeyName(53, "winxp_ico_shell32_dll-053.png");
            this.imageList1.Images.SetKeyName(54, "winxp_ico_shell32_dll-054.png");
            this.imageList1.Images.SetKeyName(55, "winxp_ico_shell32_dll-055.png");
            this.imageList1.Images.SetKeyName(56, "winxp_ico_shell32_dll-056.png");
            this.imageList1.Images.SetKeyName(57, "winxp_ico_shell32_dll-057.png");
            this.imageList1.Images.SetKeyName(58, "winxp_ico_shell32_dll-058.png");
            this.imageList1.Images.SetKeyName(59, "winxp_ico_shell32_dll-059.png");
            this.imageList1.Images.SetKeyName(60, "winxp_ico_shell32_dll-060.png");
            this.imageList1.Images.SetKeyName(61, "winxp_ico_shell32_dll-061.png");
            this.imageList1.Images.SetKeyName(62, "winxp_ico_shell32_dll-062.png");
            this.imageList1.Images.SetKeyName(63, "winxp_ico_shell32_dll-063.png");
            this.imageList1.Images.SetKeyName(64, "winxp_ico_shell32_dll-064.png");
            this.imageList1.Images.SetKeyName(65, "winxp_ico_shell32_dll-065.png");
            this.imageList1.Images.SetKeyName(66, "winxp_ico_shell32_dll-066.png");
            this.imageList1.Images.SetKeyName(67, "winxp_ico_shell32_dll-067.png");
            this.imageList1.Images.SetKeyName(68, "winxp_ico_shell32_dll-068.png");
            this.imageList1.Images.SetKeyName(69, "winxp_ico_shell32_dll-069.png");
            this.imageList1.Images.SetKeyName(70, "winxp_ico_shell32_dll-070.png");
            this.imageList1.Images.SetKeyName(71, "winxp_ico_shell32_dll-071.png");
            this.imageList1.Images.SetKeyName(72, "winxp_ico_shell32_dll-072.png");
            this.imageList1.Images.SetKeyName(73, "winxp_ico_shell32_dll-073.png");
            this.imageList1.Images.SetKeyName(74, "winxp_ico_shell32_dll-074.png");
            this.imageList1.Images.SetKeyName(75, "winxp_ico_shell32_dll-075.png");
            this.imageList1.Images.SetKeyName(76, "winxp_ico_shell32_dll-076.png");
            this.imageList1.Images.SetKeyName(77, "winxp_ico_shell32_dll-077.png");
            this.imageList1.Images.SetKeyName(78, "winxp_ico_shell32_dll-078.png");
            this.imageList1.Images.SetKeyName(79, "winxp_ico_shell32_dll-079.png");
            this.imageList1.Images.SetKeyName(80, "winxp_ico_shell32_dll-080.png");
            this.imageList1.Images.SetKeyName(81, "winxp_ico_shell32_dll-081.png");
            this.imageList1.Images.SetKeyName(82, "winxp_ico_shell32_dll-082.png");
            this.imageList1.Images.SetKeyName(83, "winxp_ico_shell32_dll-083.png");
            this.imageList1.Images.SetKeyName(84, "winxp_ico_shell32_dll-084.png");
            this.imageList1.Images.SetKeyName(85, "winxp_ico_shell32_dll-085.png");
            this.imageList1.Images.SetKeyName(86, "winxp_ico_shell32_dll-086.png");
            this.imageList1.Images.SetKeyName(87, "winxp_ico_shell32_dll-087.png");
            this.imageList1.Images.SetKeyName(88, "winxp_ico_shell32_dll-088.png");
            this.imageList1.Images.SetKeyName(89, "winxp_ico_shell32_dll-089.png");
            this.imageList1.Images.SetKeyName(90, "winxp_ico_shell32_dll-090.png");
            this.imageList1.Images.SetKeyName(91, "winxp_ico_shell32_dll-091.png");
            this.imageList1.Images.SetKeyName(92, "winxp_ico_shell32_dll-092.png");
            this.imageList1.Images.SetKeyName(93, "winxp_ico_shell32_dll-093.png");
            this.imageList1.Images.SetKeyName(94, "winxp_ico_shell32_dll-094.png");
            this.imageList1.Images.SetKeyName(95, "winxp_ico_shell32_dll-095.png");
            this.imageList1.Images.SetKeyName(96, "winxp_ico_shell32_dll-096.png");
            this.imageList1.Images.SetKeyName(97, "winxp_ico_shell32_dll-097.png");
            this.imageList1.Images.SetKeyName(98, "winxp_ico_shell32_dll-098.png");
            this.imageList1.Images.SetKeyName(99, "winxp_ico_shell32_dll-099.png");
            this.imageList1.Images.SetKeyName(100, "winxp_ico_shell32_dll-100.png");
            this.imageList1.Images.SetKeyName(101, "winxp_ico_shell32_dll-101.png");
            this.imageList1.Images.SetKeyName(102, "winxp_ico_shell32_dll-102.png");
            this.imageList1.Images.SetKeyName(103, "winxp_ico_shell32_dll-103.png");
            this.imageList1.Images.SetKeyName(104, "winxp_ico_shell32_dll-104.png");
            this.imageList1.Images.SetKeyName(105, "winxp_ico_shell32_dll-105.png");
            this.imageList1.Images.SetKeyName(106, "winxp_ico_shell32_dll-106.png");
            this.imageList1.Images.SetKeyName(107, "winxp_ico_shell32_dll-107.png");
            this.imageList1.Images.SetKeyName(108, "winxp_ico_shell32_dll-108.png");
            this.imageList1.Images.SetKeyName(109, "winxp_ico_shell32_dll-109.png");
            this.imageList1.Images.SetKeyName(110, "winxp_ico_shell32_dll-110.png");
            this.imageList1.Images.SetKeyName(111, "winxp_ico_shell32_dll-111.png");
            this.imageList1.Images.SetKeyName(112, "winxp_ico_shell32_dll-112.png");
            this.imageList1.Images.SetKeyName(113, "winxp_ico_shell32_dll-113.png");
            this.imageList1.Images.SetKeyName(114, "winxp_ico_shell32_dll-114.png");
            this.imageList1.Images.SetKeyName(115, "winxp_ico_shell32_dll-115.png");
            this.imageList1.Images.SetKeyName(116, "winxp_ico_shell32_dll-116.png");
            this.imageList1.Images.SetKeyName(117, "winxp_ico_shell32_dll-117.png");
            this.imageList1.Images.SetKeyName(118, "winxp_ico_shell32_dll-118.png");
            this.imageList1.Images.SetKeyName(119, "winxp_ico_shell32_dll-119.png");
            this.imageList1.Images.SetKeyName(120, "winxp_ico_shell32_dll-120.png");
            this.imageList1.Images.SetKeyName(121, "winxp_ico_shell32_dll-121.png");
            this.imageList1.Images.SetKeyName(122, "winxp_ico_shell32_dll-122.png");
            this.imageList1.Images.SetKeyName(123, "winxp_ico_shell32_dll-123.png");
            this.imageList1.Images.SetKeyName(124, "winxp_ico_shell32_dll-124.png");
            this.imageList1.Images.SetKeyName(125, "winxp_ico_shell32_dll-125.png");
            this.imageList1.Images.SetKeyName(126, "winxp_ico_shell32_dll-126.png");
            this.imageList1.Images.SetKeyName(127, "winxp_ico_shell32_dll-127.png");
            this.imageList1.Images.SetKeyName(128, "winxp_ico_shell32_dll-128.png");
            this.imageList1.Images.SetKeyName(129, "winxp_ico_shell32_dll-129.png");
            this.imageList1.Images.SetKeyName(130, "winxp_ico_shell32_dll-130.png");
            this.imageList1.Images.SetKeyName(131, "winxp_ico_shell32_dll-131.png");
            this.imageList1.Images.SetKeyName(132, "winxp_ico_shell32_dll-132.png");
            this.imageList1.Images.SetKeyName(133, "winxp_ico_shell32_dll-133.png");
            this.imageList1.Images.SetKeyName(134, "winxp_ico_shell32_dll-134.png");
            this.imageList1.Images.SetKeyName(135, "winxp_ico_shell32_dll-135.png");
            this.imageList1.Images.SetKeyName(136, "winxp_ico_shell32_dll-136.png");
            this.imageList1.Images.SetKeyName(137, "winxp_ico_shell32_dll-137.png");
            this.imageList1.Images.SetKeyName(138, "winxp_ico_shell32_dll-138.png");
            this.imageList1.Images.SetKeyName(139, "winxp_ico_shell32_dll-139.png");
            this.imageList1.Images.SetKeyName(140, "winxp_ico_shell32_dll-140.png");
            this.imageList1.Images.SetKeyName(141, "winxp_ico_shell32_dll-141.png");
            this.imageList1.Images.SetKeyName(142, "winxp_ico_shell32_dll-142.png");
            this.imageList1.Images.SetKeyName(143, "winxp_ico_shell32_dll-143.png");
            this.imageList1.Images.SetKeyName(144, "winxp_ico_shell32_dll-144.png");
            this.imageList1.Images.SetKeyName(145, "winxp_ico_shell32_dll-145.png");
            this.imageList1.Images.SetKeyName(146, "winxp_ico_shell32_dll-146.png");
            this.imageList1.Images.SetKeyName(147, "winxp_ico_shell32_dll-147.png");
            this.imageList1.Images.SetKeyName(148, "winxp_ico_shell32_dll-148.png");
            this.imageList1.Images.SetKeyName(149, "winxp_ico_shell32_dll-149.png");
            this.imageList1.Images.SetKeyName(150, "winxp_ico_shell32_dll-150.png");
            this.imageList1.Images.SetKeyName(151, "winxp_ico_shell32_dll-151.png");
            this.imageList1.Images.SetKeyName(152, "winxp_ico_shell32_dll-152.png");
            this.imageList1.Images.SetKeyName(153, "winxp_ico_shell32_dll-153.png");
            this.imageList1.Images.SetKeyName(154, "winxp_ico_shell32_dll-154.png");
            this.imageList1.Images.SetKeyName(155, "winxp_ico_shell32_dll-155.png");
            this.imageList1.Images.SetKeyName(156, "winxp_ico_shell32_dll-156.png");
            this.imageList1.Images.SetKeyName(157, "winxp_ico_shell32_dll-157.png");
            this.imageList1.Images.SetKeyName(158, "winxp_ico_shell32_dll-158.png");
            this.imageList1.Images.SetKeyName(159, "winxp_ico_shell32_dll-159.png");
            this.imageList1.Images.SetKeyName(160, "winxp_ico_shell32_dll-160.png");
            this.imageList1.Images.SetKeyName(161, "winxp_ico_shell32_dll-161.png");
            this.imageList1.Images.SetKeyName(162, "winxp_ico_shell32_dll-162.png");
            this.imageList1.Images.SetKeyName(163, "winxp_ico_shell32_dll-163.png");
            this.imageList1.Images.SetKeyName(164, "winxp_ico_shell32_dll-164.png");
            this.imageList1.Images.SetKeyName(165, "winxp_ico_shell32_dll-165.png");
            this.imageList1.Images.SetKeyName(166, "winxp_ico_shell32_dll-166.png");
            this.imageList1.Images.SetKeyName(167, "winxp_ico_shell32_dll-167.png");
            this.imageList1.Images.SetKeyName(168, "winxp_ico_shell32_dll-168.png");
            this.imageList1.Images.SetKeyName(169, "winxp_ico_shell32_dll-169.png");
            this.imageList1.Images.SetKeyName(170, "winxp_ico_shell32_dll-170.png");
            this.imageList1.Images.SetKeyName(171, "winxp_ico_shell32_dll-171.png");
            this.imageList1.Images.SetKeyName(172, "winxp_ico_shell32_dll-172.png");
            this.imageList1.Images.SetKeyName(173, "winxp_ico_shell32_dll-173.png");
            this.imageList1.Images.SetKeyName(174, "winxp_ico_shell32_dll-174.png");
            this.imageList1.Images.SetKeyName(175, "winxp_ico_shell32_dll-175.png");
            this.imageList1.Images.SetKeyName(176, "winxp_ico_shell32_dll-176.png");
            this.imageList1.Images.SetKeyName(177, "winxp_ico_shell32_dll-177.png");
            this.imageList1.Images.SetKeyName(178, "winxp_ico_shell32_dll-178.png");
            this.imageList1.Images.SetKeyName(179, "winxp_ico_shell32_dll-179.png");
            this.imageList1.Images.SetKeyName(180, "winxp_ico_shell32_dll-180.png");
            this.imageList1.Images.SetKeyName(181, "winxp_ico_shell32_dll-181.png");
            this.imageList1.Images.SetKeyName(182, "winxp_ico_shell32_dll-182.png");
            this.imageList1.Images.SetKeyName(183, "winxp_ico_shell32_dll-183.png");
            this.imageList1.Images.SetKeyName(184, "winxp_ico_shell32_dll-184.png");
            this.imageList1.Images.SetKeyName(185, "winxp_ico_shell32_dll-185.png");
            this.imageList1.Images.SetKeyName(186, "winxp_ico_shell32_dll-186.png");
            this.imageList1.Images.SetKeyName(187, "winxp_ico_shell32_dll-187.png");
            this.imageList1.Images.SetKeyName(188, "winxp_ico_shell32_dll-188.png");
            this.imageList1.Images.SetKeyName(189, "winxp_ico_shell32_dll-189.png");
            this.imageList1.Images.SetKeyName(190, "winxp_ico_shell32_dll-190.png");
            this.imageList1.Images.SetKeyName(191, "winxp_ico_shell32_dll-191.png");
            this.imageList1.Images.SetKeyName(192, "winxp_ico_shell32_dll-192.png");
            this.imageList1.Images.SetKeyName(193, "winxp_ico_shell32_dll-193.png");
            this.imageList1.Images.SetKeyName(194, "winxp_ico_shell32_dll-194.png");
            this.imageList1.Images.SetKeyName(195, "winxp_ico_shell32_dll-195.png");
            this.imageList1.Images.SetKeyName(196, "winxp_ico_shell32_dll-196.png");
            this.imageList1.Images.SetKeyName(197, "winxp_ico_shell32_dll-197.png");
            this.imageList1.Images.SetKeyName(198, "winxp_ico_shell32_dll-198.png");
            this.imageList1.Images.SetKeyName(199, "winxp_ico_shell32_dll-199.png");
            this.imageList1.Images.SetKeyName(200, "winxp_ico_shell32_dll-200.png");
            this.imageList1.Images.SetKeyName(201, "winxp_ico_shell32_dll-201.png");
            this.imageList1.Images.SetKeyName(202, "winxp_ico_shell32_dll-202.png");
            this.imageList1.Images.SetKeyName(203, "winxp_ico_shell32_dll-203.png");
            this.imageList1.Images.SetKeyName(204, "winxp_ico_shell32_dll-204.png");
            this.imageList1.Images.SetKeyName(205, "winxp_ico_shell32_dll-205.png");
            this.imageList1.Images.SetKeyName(206, "winxp_ico_shell32_dll-206.png");
            this.imageList1.Images.SetKeyName(207, "winxp_ico_shell32_dll-207.png");
            this.imageList1.Images.SetKeyName(208, "winxp_ico_shell32_dll-208.png");
            this.imageList1.Images.SetKeyName(209, "winxp_ico_shell32_dll-209.png");
            this.imageList1.Images.SetKeyName(210, "winxp_ico_shell32_dll-210.png");
            this.imageList1.Images.SetKeyName(211, "winxp_ico_shell32_dll-211.png");
            this.imageList1.Images.SetKeyName(212, "winxp_ico_shell32_dll-212.png");
            this.imageList1.Images.SetKeyName(213, "winxp_ico_shell32_dll-213.png");
            this.imageList1.Images.SetKeyName(214, "winxp_ico_shell32_dll-214.png");
            this.imageList1.Images.SetKeyName(215, "winxp_ico_shell32_dll-215.png");
            this.imageList1.Images.SetKeyName(216, "winxp_ico_shell32_dll-216.png");
            this.imageList1.Images.SetKeyName(217, "winxp_ico_shell32_dll-217.png");
            this.imageList1.Images.SetKeyName(218, "winxp_ico_shell32_dll-218.png");
            this.imageList1.Images.SetKeyName(219, "winxp_ico_shell32_dll-219.png");
            this.imageList1.Images.SetKeyName(220, "winxp_ico_shell32_dll-220.png");
            this.imageList1.Images.SetKeyName(221, "winxp_ico_shell32_dll-221.png");
            this.imageList1.Images.SetKeyName(222, "winxp_ico_shell32_dll-222.png");
            this.imageList1.Images.SetKeyName(223, "winxp_ico_shell32_dll-223.png");
            this.imageList1.Images.SetKeyName(224, "winxp_ico_shell32_dll-224.png");
            this.imageList1.Images.SetKeyName(225, "winxp_ico_shell32_dll-225.png");
            this.imageList1.Images.SetKeyName(226, "winxp_ico_shell32_dll-226.png");
            this.imageList1.Images.SetKeyName(227, "winxp_ico_shell32_dll-227.png");
            this.imageList1.Images.SetKeyName(228, "winxp_ico_shell32_dll-228.png");
            this.imageList1.Images.SetKeyName(229, "winxp_ico_shell32_dll-229.png");
            this.imageList1.Images.SetKeyName(230, "winxp_ico_shell32_dll-230.png");
            this.imageList1.Images.SetKeyName(231, "winxp_ico_shell32_dll-231.png");
            this.imageList1.Images.SetKeyName(232, "winxp_ico_shell32_dll-232.png");
            this.imageList1.Images.SetKeyName(233, "winxp_ico_shell32_dll-233.png");
            this.imageList1.Images.SetKeyName(234, "winxp_ico_shell32_dll-234.png");
            this.imageList1.Images.SetKeyName(235, "winxp_ico_shell32_dll-235.png");
            this.imageList1.Images.SetKeyName(236, "winxp_ico_shell32_dll-236.png");
            this.imageList1.Images.SetKeyName(237, "winxp_ico_shell32_dll-237.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.type,
            this.dateModified,
            this.readOnly});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(251, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(633, 426);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.doubled);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 280;
            // 
            // type
            // 
            this.type.Text = "Type";
            this.type.Width = 108;
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date modified";
            this.dateModified.Width = 137;
            // 
            // readOnly
            // 
            this.readOnly.Text = "Read only?";
            this.readOnly.Width = 104;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(896, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 189);
            this.panel1.TabIndex = 3;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(12, 17);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(191, 13);
            this.loadingLabel.TabIndex = 4;
            this.loadingLabel.Text = "Loading files. This may take some time.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 666);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.ColumnHeader readOnly;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loadingLabel;
    }
}

