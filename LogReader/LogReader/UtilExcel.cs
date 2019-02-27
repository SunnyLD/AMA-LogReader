using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace LogReader
{
    public sealed class UtilExcel
    {
        public static void ExportCommonGridtoExcel(System.Windows.Forms.DataGridView grid)
        {
            if (grid == null || grid.DataSource == null || grid.Rows.Count == 0 || grid.Columns.Count == 0) return;
            System.Windows.Forms.SaveFileDialog sfDialog = new System.Windows.Forms.SaveFileDialog();
            sfDialog.Filter = "Excel files(*.xls)|*.xls";
            sfDialog.FilterIndex = 1;
            sfDialog.DefaultExt = ".xls";
            //sfDialog.InitialDirectory = Environment.CurrentDirectory;
            sfDialog.RestoreDirectory = true;
            if (sfDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                MemoryStream ms = new MemoryStream();

                NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet("Sheet1");

                int colCount = 0;
                NPOI.SS.UserModel.IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                        cell.SetCellValue(grid.Columns[i].HeaderText);
                    }
                }

                int rowCount = 1;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    colCount = 0;
                    if (grid.Rows[i].Visible)
                    {
                        NPOI.SS.UserModel.IRow dataRow = sheet.CreateRow(rowCount++);
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            if (grid.Columns[j].Visible)
                            {
                                NPOI.SS.UserModel.ICell cell = dataRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                                if (grid.Rows[i].Cells[j].Value != null)
                                {
                                    cell.SetCellValue(grid.Rows[i].Cells[j].Value.ToString());
                                }
                                else
                                {
                                    cell.SetCellValue(string.Empty);
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                }
                workbook.Write(ms);
                FileStream file = new FileStream(sfDialog.FileName, FileMode.Create);
                workbook.Write(file);
                file.Close();
                workbook = null;
                ms.Close();
                ms.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExportCommonGridtoExcel(System.Windows.Forms.DataGridView grid, string sheetName, out string fileName)
        {
            fileName = "";
            if (grid == null || grid.DataSource == null || grid.Rows.Count == 0 || grid.Columns.Count == 0) return;
            System.Windows.Forms.SaveFileDialog sfDialog = new System.Windows.Forms.SaveFileDialog();
            sfDialog.Filter = "Excel files(*.xls)|*.xls";
            sfDialog.FilterIndex = 1;
            sfDialog.DefaultExt = ".xls";
            //sfDialog.InitialDirectory = Environment.CurrentDirectory;
            sfDialog.RestoreDirectory = true;
            if (sfDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                MemoryStream ms = new MemoryStream();

                NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet(string.IsNullOrEmpty(sheetName) ? "Sheet1" : sheetName);

                int colCount = 0;
                NPOI.SS.UserModel.IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                        cell.SetCellValue(grid.Columns[i].HeaderText);

                    }
                }

                int rowCount = 1;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    colCount = 0;
                    if (grid.Rows[i].Visible)
                    {
                        NPOI.SS.UserModel.IRow dataRow = sheet.CreateRow(rowCount++);
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            if (grid.Columns[j].Visible)
                            {
                                NPOI.SS.UserModel.ICell cell = dataRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                                if (grid.Rows[i].Cells[j] != null && grid.Rows[i].Cells[j].Value != null)
                                {
                                    cell.SetCellValue(grid.Rows[i].Cells[j].Value.ToString());
                                }
                                else
                                {
                                    cell.SetCellValue(string.Empty);
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                }
                workbook.Write(ms);
                FileStream file = new FileStream(sfDialog.FileName, FileMode.Create);
                workbook.Write(file);
                file.Close();
                workbook = null;
                ms.Close();
                ms.Dispose();

                fileName = sfDialog.FileName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ExportCommonGridtoExcel(System.Windows.Forms.DataGridView grid, string fileName)
        {
            if (grid == null || grid.DataSource == null
                || grid.Rows.Count == 0 || grid.Columns.Count == 0
                || string.IsNullOrEmpty(fileName)) return;

            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                MemoryStream ms = new MemoryStream();

                NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet("Sheet1");

                int colCount = 0;
                NPOI.SS.UserModel.IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                        cell.SetCellValue(grid.Columns[i].HeaderText);

                    }
                }

                int rowCount = 1;
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    colCount = 0;
                    if (grid.Rows[i].Visible)
                    {
                        NPOI.SS.UserModel.IRow dataRow = sheet.CreateRow(rowCount++);
                        for (int j = 0; j < grid.Columns.Count; j++)
                        {
                            if (grid.Columns[j].Visible)
                            {
                                NPOI.SS.UserModel.ICell cell = dataRow.CreateCell(colCount++, NPOI.SS.UserModel.CellType.String);
                                if (grid.Rows[i].Cells[j] != null && grid.Rows[i].Cells[j].Value != null)
                                {
                                    cell.SetCellValue(grid.Rows[i].Cells[j].Value.ToString());
                                }
                                else
                                {
                                    cell.SetCellValue(string.Empty);
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                }
                workbook.Write(ms);
                FileStream file = new FileStream(fileName, FileMode.Create);
                workbook.Write(file);
                file.Close();
                workbook = null;
                ms.Close();
                ms.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataSet ReadExcelFromPath(string path)
        {
            FileStream fs = null;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                IWorkbook wb = null;
                fs = File.Open(path, FileMode.Open, FileAccess.Read);
                switch (Path.GetExtension(path).ToUpper())
                {
                    case ".XLS":
                        {
                            wb = new HSSFWorkbook(fs);
                        }
                        break;
                    case ".XLSX":
                        {
                            wb = new XSSFWorkbook(fs);
                        }
                        break;
                }
                if (wb.NumberOfSheets > 0)
                {
                    for (int k = 0; k < wb.NumberOfSheets; k++)
                    {
                        ISheet sheet = wb.GetSheetAt(k);
                        dt = new DataTable(sheet.SheetName);
                        IRow headerRow = sheet.GetRow(0);
                        ICell cell = null;
                        IRow row = null;
                        DataRow dr = null;

                        if (headerRow == null) continue;
                        //處理標題列
                        for (int i = headerRow.FirstCellNum; i < headerRow.LastCellNum; i++)
                        {
                            cell = headerRow.GetCell(i);
                            if (cell == null) continue;

                            dt.Columns.Add(cell.StringCellValue.Trim());
                        }

                        //標題列之後的資料
                        for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                        {
                            dr = dt.NewRow();
                            row = sheet.GetRow(i);
                            if (row == null) continue;
                            int columnIndex = row.FirstCellNum;//Jerry 2017/2/20 Bug ID 6698
                            for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                            {
                                cell = row.GetCell(j);
                                if (cell == null)
                                    dr[columnIndex] = string.Empty;

                                else if (cell.CellType == CellType.Numeric)
                                    dr[columnIndex] = cell.NumericCellValue.ToString();

                                else if (cell.CellType == CellType.String)
                                    dr[columnIndex] = cell.StringCellValue;

                                columnIndex++;
                            }
                            dt.Rows.Add(dr);
                        }
                        ds.Tables.Add(dt.Copy());
                    }
                }
                fs.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (fs != null) fs.Dispose();
            }
            return ds;
        }

        public static bool DataTableToExcelFile(DataTable dt, string path)
        {
            //建立Excel 2003檔案
            IWorkbook wb = new HSSFWorkbook();
            ISheet ws;

            ////建立Excel 2007檔案
            //IWorkbook wb = new XSSFWorkbook();
            //ISheet ws;

            try
            {
                if (dt.TableName != string.Empty)
                {
                    ws = wb.CreateSheet(dt.TableName);
                }
                else
                {
                    ws = wb.CreateSheet("Sheet1");
                }

                ws.CreateRow(0);//第一行為欄位名稱
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.GetRow(0).CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ws.CreateRow(i + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.GetRow(i + 1).CreateCell(j).SetCellValue(dt.Rows[i][j].ToString());
                    }
                }

                FileStream file = new FileStream(path, FileMode.Create);//產生檔案
                wb.Write(file);
                file.Close();
                return true;
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
