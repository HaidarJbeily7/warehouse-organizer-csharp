using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Drawing;


namespace Store_Organiser
{
    class GridPrinting
    {
        private static string HeaderText = "";

        // Printing DevExpress Grid Control Component
        public static void PrintGrid(GridControl gridControl, GridView gridView, string headerText)
        {
            HeaderText = headerText;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            // عكس ترتيب الأعمدة
            //ReverseColumnsOrder(gridView);


            link.Component = gridControl;

            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            // Subscribe to the CreateReportHeaderArea event used to generate the report header. 
            link.CreateReportHeaderArea += link_CreateReportHeaderArea;
            link.CreateMarginalFooterArea += link_CreateMarginalFooterArea;

            link.Margins = new System.Drawing.Printing.Margins(50, 50, 110, 100);
            link.CreateDocument();

            link.ShowRibbonPreviewDialog(gridControl.LookAndFeel);

            // إعادة ترتيب الأعمدة
            // ReOrderColmns(gridView);
        }

        private static void link_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = HeaderText;
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("PT Bold Heading", 18);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }


        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            // Specify required settings for the brick graphics. 
            BrickGraphics brickGraphics = e.Graph;
            brickGraphics.BackColor = Color.White;

            // Declare bricks. 
            PageImageBrick pageImageBrick;
            PageInfoBrick pageInfoBrick = new PageInfoBrick();

            // Define the image to display. 
           // Image pageImage = MainForm.Properties.Resources.logo;

            // Display the PageImageBrick containing the DevExpress logo. 
          //  pageImageBrick = brickGraphics.DrawPageImage(pageImage, new RectangleF(343, 0,
            //    pageImage.Width, pageImage.Height), BorderSide.None, Color.Transparent);
            //pageImageBrick.Alignment = BrickAlignment.Far;

            TextBrick brick2 = new TextBrick(BorderSide.None, 0, Color.White, Color.White, Color.Black);
            DateTime todaysDate = DateTime.Now;
            brick2.Text = "تاريخ: " + todaysDate.ToShortDateString() + " ، الساعة :" + todaysDate.ToShortTimeString();
            brick2.Rect = new RectangleF(0, 0, 200, 20);
            //brick2.Font = new Font(brick2.Font, FontStyle);

            e.Graph.DrawBrick(brick2);
        }

        private static void link_CreateMarginalFooterArea(object sender, CreateAreaEventArgs e)
        {
            PageInfoBrick pageInfoBrick = new PageInfoBrick();
            pageInfoBrick = e.Graph.DrawPageInfo(PageInfo.NumberOfTotal, "الصفحة {0} من {1}", Color.Black, new RectangleF(0, 0, 250, 20), BorderSide.None);
            pageInfoBrick.Alignment = BrickAlignment.Near;
        }

        // عكس ترتيب الأعمدة
        public static void ReverseColumnsOrder(GridView gridView)
        {
            List<int> ColumnsIndecies = new List<int>();

            for (int i = 0; i < gridView.VisibleColumns.Count; i++)
            {
                gridView.VisibleColumns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                ColumnsIndecies.Add(gridView.VisibleColumns[i].VisibleIndex);
            }

            int maxIndex = gridView.VisibleColumns.Count - 1;

            for (int i = 0; i < ColumnsIndecies.Count - 1; i++)
            {
                gridView.VisibleColumns[maxIndex].VisibleIndex = ColumnsIndecies[i];
            }
        }

        private static void ReOrderColmns(GridView gridView)
        {
            List<int> ColumnsIndecies = new List<int>();

            for (int i = 0; i < gridView.VisibleColumns.Count; i++)
            {
                gridView.VisibleColumns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                ColumnsIndecies.Add(gridView.VisibleColumns[i].VisibleIndex);
            }

            int maxIndex = gridView.VisibleColumns.Count - 1;

            for (int i = 0; i < ColumnsIndecies.Count - 1; i++)
            {
                gridView.VisibleColumns[maxIndex].VisibleIndex = ColumnsIndecies[i];
            }
        }

    }
}
