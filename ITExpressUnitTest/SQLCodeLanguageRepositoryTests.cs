using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Repository;
using DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using Abstraction.Interfaces;

namespace ITExpressUnitTest
{
    [TestClass]
    public class SQLCodeLanguageRepositoryTests
    {
        readonly SQLCodeLanguageRepository repository = new SQLCodeLanguageRepository();

        [TestMethod]
        public void AddCodeLanguageTest()
        {
            //Arrange
            bool isFound = false;
            CodeLanguage cl = new CodeLanguage
            {
                Language = "Test"
            };

            //Act
            repository.AddCodeLanguage(cl);
            List<ICodeLanguage> codeLanguages = repository.GetAllCodeLanguages();

            //Assert
            foreach(ICodeLanguage codeLanguage = codeLanguages)
            {
                if(codeLanguage.Language == "Test")
                {
                    isFound = true;
                }
            }
            Assert.IsTrue(isFound);
        }
    }
}
