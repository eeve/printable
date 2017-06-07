using System;
using System.Collections.Generic;
using System.Text;

namespace printable
{
    class TestModel
    {
        public string name { get; set; }
        public int age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            TestModel[] tms = new TestModel[]{
                new TestModel() {
                    name = "今晚打老虎",
                    age = 18000000
                },
                new TestModel() {
                    name = "hello world, hello world",
                    age = 20
                }
            };
            TestModel[] tms2 = new TestModel[]{
                new TestModel() {
                    name = "hello world",
                    age = 112128
                }
            };
            Console.WriteLine(tms.ToStringTable(a => a.name, a => a.age));
            Console.WriteLine(tms2.ToStringTable(a => a.name, a => a.age));
        }
    }
}
