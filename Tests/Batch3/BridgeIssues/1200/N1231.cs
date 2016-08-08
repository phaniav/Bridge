using Bridge.Test;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1231 - {0}")]
    public class Bridge1231
    {
        public interface I1<T>
        {
        }

        [Namespace("Demo")]
        public class Class1<T>
        {
            public struct MyStruct : I1<T>
            {
                public MyStruct(int field)
                {
                    this.field = field;
                }

                public int field;
            }
        }

        [Test]
        public static void TestAutoGeneratedStructMethodName()
        {
            var struct1 = new Class1<string>.MyStruct(1);
            var struct2 = struct1;
            struct2.field = 2;

            Assert.AreEqual(1, struct1.field);
            Assert.AreEqual(2, struct2.field);
        }
    }
}