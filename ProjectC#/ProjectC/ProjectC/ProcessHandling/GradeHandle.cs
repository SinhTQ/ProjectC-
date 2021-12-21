using ProjectC.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectC.ProcessHandling
{
    class GradeHandle
    {

        internal static List<TestCase> loadTestCase(string TestCaseFolder)
        {

            List<TestCase> list = new List<TestCase>();
            string[] madeFolder = Directory.GetDirectories(TestCaseFolder);
            for (int i = 0; i < madeFolder.Length; i++)
            {
                string paper = madeFolder[i].Substring(madeFolder[i].LastIndexOf("\\") + 1);
                int paperNo = Convert.ToInt32(paper.Substring(paper.Length - 1));
                string[] Question = Directory.GetDirectories(madeFolder[i]);
                for (int j = 0; j < Question.Length; j++)
                {
                    int q = Convert.ToInt32((Question[j].Substring(Question[j].LastIndexOf("\\") + 1)).Substring(1, 1));
                    string[] files = Directory.GetFiles(Question[j]);
                    for (int k = 0; k < files.Length; k++)
                    {
                        string filePath = files[k];
                        TestCase tc = GradeHandle.GetFile(filePath);
                        tc.PaperNo = paperNo;
                        tc.Question = q;
                        list.Add(tc);
                    }
                }
            }

            //string[] Question = Directory.GetFiles(madeFolder[i]);
            //string made=madeFolder[i].Substring(madeFolder[i].LastIndexOf("\\") + 1);
            //for (int j = 0; j < Question.Length; j++)
            //{
            //    int q=Convert.ToInt32((Question[j].Substring(Question[j].LastIndexOf("\\") + 1)).Substring(1,1));
            //    TestCase tc = GradeHandle.GetFile(Question[j]);
            //    tc.Made = made;
            //    tc.Question = q;
            //    list.Add(tc);
            //}

            //Console.WriteLine("number file:"+files.Length);
            return list;
        }

        private static TestCase GetFile(string filePath)
        {
            TestCase tc = new TestCase();
            StreamReader streamReader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));

            string text2 = streamReader.ReadToEnd();
            string[] stringArr = text2.Split('|');

            for (int k = Array.IndexOf(stringArr, "OUTPUT:") + 1; k < Array.IndexOf(stringArr, "MARK:"); k++)
            {

                tc.Output = tc.Output + stringArr[k];

            }
            for (int j = Array.IndexOf(stringArr, "INPUT:") + 1; j < Array.IndexOf(stringArr, "OUTPUT:"); j++)
            {
                tc.Input.Add(stringArr[j]);
            }

            for (int j = Array.IndexOf(stringArr, "MARK:") + 1; j < stringArr.Length; j++)
            {
                // int k = Array.IndexOf(stringArr, "MARK:");

                   tc.Mark = Convert.ToDouble(stringArr[j]);
               // Console.WriteLine(stringArr[j]);
            }

            streamReader.Close();
            tc.Output = tc.Output.Trim();
            return tc;
        }
        internal static string avc(string txtTestCase)
        {
            string[] files = Directory.GetFiles(txtTestCase);

            return files[0];
        }

        internal static void StudentMark(string programPath, string testcase, int paperNo, Student stu)
        {

            //    Student stu = new Student();

            for (int i = 1; i < 6; i++)
            {

                List<TestCase> listTestCase = GradeHandle.loadTestCase(testcase);
                int j;
                double mark = 0;
                for (j = 0; j < listTestCase.Count; j++)
                {

                    if (paperNo == listTestCase[j].PaperNo && i == listTestCase[j].Question)
                    {
                        TestCase test = listTestCase[j];
                        Process process = new Process();
                        process.StartInfo.FileName = "cmd.exe";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardInput = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();

                        StreamWriter streamWriter = process.StandardInput;
                        StreamReader streamReader = process.StandardOutput;

                        Form1 a = new Form1();
                        streamWriter.WriteLine(@"cd \");
                        streamWriter.WriteLine(@"cd /d " + programPath);



                        streamWriter.WriteLine("Q" + i + ".exe");

                        foreach (string item in test.Input)
                        {
                            streamWriter.WriteLine(item);
                        }

                        streamWriter.Flush();
                        streamWriter.Close();
                        string text = "";
                        string str;
                        while ((str = streamReader.ReadLine()) != null)
                        {
                            text += str;
                        }
                        process.WaitForExit();
                        process.Close();
                        int num = text.LastIndexOf("OUTPUT:");
                        string text2 = text.Substring(num + 7, text.Length - (num + 7 + (programPath.Length + 1)));
                        text2 = text2.Trim();

                        if (test.Output.Equals(text2))
                        {
                            mark +=test.Mark ;
                        }
                    }


                }
                stu.TotalMark += mark;
                if (mark != 2)
                {
                    stu.Note += "[QN=" + i + ", Mark=" + mark + "];";

                }


            }



        }



        internal static void loadStudent(string classFolder, string TestCaseFolder, List<Student> list, ref int load)
        {


            string[] classFol = Directory.GetDirectories(classFolder);
            Form1 form = new Form1();
            for (int j = 0; j < list.Count; j++)
            {
                int c = 0;
                for (int i = 0; i < classFol.Length; i++)
                {
                    string filePath = classFol[i];
                    string[] name = (filePath.Substring(filePath.LastIndexOf("\\") + 1)).Split('_');
                    string stuId1 = name[0];
                    int paperNo = Convert.ToInt32(name[2]);


                    if (list[j].StuId.Equals(stuId1))
                    {

                        GradeHandle.StudentMark(filePath, TestCaseFolder, paperNo, list[j]);
                        c++;
                        load++;
                    }


                }

                if (c == 0)
                    list[j].Note = "Student did not submit exam";

                //   list[i]= GradeHandle.StudentMark(filePath, TestCaseFolder, paperNo);


            }

        }


    }
}
