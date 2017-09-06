﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNNLanguage;
using VNNMedia;

namespace VNNLangaugeTests.ParserTests
{
    [TestFixture]
    public class MoveCharacterTests
    {
        [Test]
        public void GivenThatWeAreMovingACharacterInOneDirection_InstructorWillMoveThatCharacterInThatDirection()
        {
            //Arrange
            string command = "MOVE [Fucky] 30px Left";
            var instructor = new Mock<IInstructor>();
            var contentManager = new Mock<IContentManager>();
            instructor.Setup(i => i.RemoveCharacter(It.IsAny<string>(), Animation.FadeOut));
            var parser = new DirtyParser(instructor.Object, contentManager.Object);
            //Act
            var result = parser.Parse(command);
            //Assert
            instructor.Verify(i => i.MoveCharacterSingleDirection("Fucky", Direction.Left, 30));
            Assert.AreEqual(true, result);
        }
    }
}
