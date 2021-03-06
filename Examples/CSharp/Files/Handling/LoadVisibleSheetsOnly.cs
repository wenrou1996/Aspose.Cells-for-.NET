using System.IO;

using Aspose.Cells;
using System;

namespace Aspose.Cells.Examples.CSharp.Files.Handling
{
    public class LoadVisibleSheetsOnly
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            string sampleFile = "output.xlsx";
            string samplePath = dataDir + sampleFile;

            // Create a sample workbook
            // and put some data in first cell of all 3 sheets
            Workbook createWorkbook = new Workbook();
            createWorkbook.Worksheets["Sheet1"].Cells["A1"].Value = "Aspose";
            createWorkbook.Worksheets.Add("Sheet2").Cells["A1"].Value = "Aspose";
            createWorkbook.Worksheets.Add("Sheet3").Cells["A1"].Value = "Aspose";
            createWorkbook.Worksheets["Sheet3"].IsVisible = false;
            createWorkbook.Save(samplePath);

            // Load the sample workbook
            LoadDataOption loadDataOption = new LoadDataOption();
            loadDataOption.OnlyVisibleWorksheet = true;
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.LoadDataAndFormatting = true;
            loadOptions.LoadDataOptions = loadDataOption;

            Workbook loadWorkbook = new Workbook(samplePath, loadOptions);
            Console.WriteLine("Sheet1: A1: {0}", loadWorkbook.Worksheets["Sheet1"].Cells["A1"].Value);
            Console.WriteLine("Sheet1: A2: {0}", loadWorkbook.Worksheets["Sheet2"].Cells["A1"].Value);
            Console.WriteLine("Sheet1: A3: {0}", loadWorkbook.Worksheets["Sheet3"].Cells["A1"].Value);
            // ExEnd:1
        }
    }
}
