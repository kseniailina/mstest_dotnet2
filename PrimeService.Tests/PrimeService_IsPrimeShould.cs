using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, $"1 should not be prime");
        }
        
        [TestMethod]
        public void TestConsoleOutput()
        {
            String propertyValue = TestContext.GetType().GetProperty("system.myVar").ToString(); 
            Console.WriteLine("system.myVar = " + propertyValue);
            
            Assert.IsNotNull(propertyValue);
        }

        [TestMethod]
        [Ignore]
        public void IgnoredTest()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            var result = _primeService.IsPrime(1);
         
            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf3()
        {            
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");

            var result = _primeService.IsPrime(3);

            Assert.IsFalse(result, $"1 should not be prime");
        }
        
        [TestMethod]
        public void testAssert21()
        {            
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");

            var result = _primeService.IsPrime(3);

            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf2()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void 有永定河流经老城西南()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("北京位於華北平原的西北边缘，背靠燕山，有永定河流经老城西南，毗邻天津市、河北省，是一座有三千余年建城历史、八百六十余年建都史的历史文化名城，历史上有金、元、明、清、中华民国（北洋政府时期）等五个朝代在此定都，以及数个政权建政于此，荟萃了自元明清以来的中华文化，拥有众多历史名胜古迹和人文景观。《不列颠百科全书》将北京形容为全球最伟大的城市之一，而且断言，“这座城市是中国历史上最重要的组成部分。在中国过去的八个世纪里，不论历史是否悠久，几乎北京所有主要建筑都拥有着不可磨灭的民族和历史意义”。北京古迹众多，著名的有故宫、天坛、颐和园、圆明园、北海公园等。");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void КонстантинIВеликий()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("Римский император Константин I Великий по достоинству оценил выгодное местоположение приморского Византия, расположенного на стыке Европы и Азии. Кроме того, на решение Константина повлияла неспокойная обстановка в самом Риме: недовольство знати и постоянные распри в борьбе за трон. Император хотел увенчать свою реформаторскую деятельность созданием нового административного центра огромной державы. Закладка города состоялась осенью 324 года, и Константин лично решил обозначить его границы.");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void Римский的西北边缘()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("Lorem ipsum dolor sit amet, Римский император Константин I Великий, 北京位於華北平原的西北边缘");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void žluťoučký()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("Příliš žluťoučký kůň úpěl ďábelské ódy");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void ทดสอบนะจ๊ะ()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("ทดสอบนะจ๊ะ ทดสอบนะจ๊ะ ทดสอบนะจ๊ะ ทดสอบนะจ๊ะ ทดสอบนะจ๊ะ ทดสอบนะจ๊ะ");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void लोमड़ी()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("एक जल्दी भूरी लोमड़ी आलसी कुत्ते पर कूदता");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void \u0639\u0628\u0631()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("\u0633\u0637\u0648\u0631 \u0639\u0628\u0631 \u0627\u0644\u0623\u064a\u0627\u0645");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void ابن()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("وضع ابن الهيثم تصور واضح للعلاقة بين النموذج الرياضي المثالي ومنظومة الظواهر الملحوظة.");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void Iñtërnâtiônàlizætiøn()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("Iñtërnâtiônàlizætiøn☃💪");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
        
        [TestMethod]
        public void وضع ابن()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("وضع ابن الهيثم تصور واضح للعلاقة بين النموذج الرياضي المثالي ومنظومة الظواهر الملحوظة.");
            TestContext.WriteLine("message from test context");

            Assert.IsFalse(true, $"1 should not be prime");
        }
       
    }
}
