using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DictApp;
using System.Collections.Generic;

namespace DictAppTest
{
    [TestClass]
    public class MainFormModelTest
    {
        [TestMethod]
        public void HasPrev_should_return_false_when_with_empty_list()
        {
            MainFormModel m = CreateModel();
            m.SetWords(new List<string>());
            Assert.IsFalse(m.HasPrev());
        }

        [TestMethod]
        public void HasPrev_should_return_false_when_at_first_position()
        {
            MainFormModel m = CreateModel();
            Assert.IsFalse(m.HasPrev());
        }

        [TestMethod]
        public void HasPrev_should_return_true_when_in_the_middle()
        {
            MainFormModel m = CreateModel();
            m.MoveNext();
            Assert.IsTrue(m.HasPrev());
        }

        [TestMethod]
        public void HasNext_should_return_false_when_with_empty_list()
        {
            MainFormModel m = CreateModel();
            m.SetWords(new List<string>());
            Assert.IsFalse(m.HasNext());
        }

        [TestMethod]
        public void HasNext_should_return_false_when_at_last_position()
        {
            MainFormModel m = CreateModel();
            while (m.HasNext())
            {
                m.MoveNext();
            }
            Assert.IsFalse(m.HasNext());
        }

        [TestMethod]
        public void HasNext_should_return_true_when_in_the_middle()
        {
            MainFormModel m = CreateModel();
            m.MoveNext();
            Assert.IsTrue(m.HasNext());
        }

        [TestMethod]
        public void GetCurrentWord_should_return_current_word()
        {
            MainFormModel m = CreateModel();
            Assert.AreEqual("example", m.GetCurrentWord());
            m.MoveNext();
            Assert.AreEqual("education", m.GetCurrentWord());
        }

        [TestMethod]
        public void GetCurrentWord_should_return_dummy_when_list_is_empty()
        {
            MainFormModel m = CreateModel();
            m.SetWords(new List<string>());
            Assert.AreEqual("-", m.GetCurrentWord());
        }

        [TestMethod]
        public void GetCurrentWordAudioUrl_should_return_url()
        {
            MainFormModel m = CreateModel();
            string url = m.GetCurrentWordAudioUrl();
            string expect = "http://dict.youdao.com/speech?audio=example";
            Assert.AreEqual(expect, url);
        }

        private MainFormModel CreateModel()
        {
            List<String> words = new List<string>();
            words.Add("example");
            words.Add("education");
            words.Add("estimation");

            MainFormModel m = new MainFormModel();
            m.SetWords(words);

            return m;
        }
    }
}
