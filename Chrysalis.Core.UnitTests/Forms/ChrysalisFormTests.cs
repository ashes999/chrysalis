using Chrysalis.Core.Forms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysalis.Core.UnitTests.Forms
{
    [TestFixture]
    class ChrysalisFormTests
    {
        [Test]
        public void LoadEventSetsFormSizeToDefaultFromConfig()
        {
            var expectedWidth = Config.DefaultFormWidth;
            var expectedHeight = Config.DefaultFormHeight;

            var actual = new TestChrysalisForm();
            Assert.That(actual.Width, Is.Not.EqualTo(expectedWidth));
            Assert.That(actual.Height, Is.Not.EqualTo(expectedHeight));

            actual.OnLoad();
            Assert.That(actual.Width, Is.EqualTo(expectedWidth));
            Assert.That(actual.Height, Is.EqualTo(expectedHeight));
        }

        [Test]
        public void ClickCancelClosesTheDialog()
        {
            var actual = new TestChrysalisForm();
            Assert.IsFalse(actual.IsDisposed);
            actual.ClickCancel();
            Assert.IsTrue(actual.IsDisposed);
        }

        [Test]
        public void CancelButtonMovesWhenResizeEventFires()
        {
            var actual = new TestChrysalisForm();
            var originalX = actual.CancelButton.Left;
            var originalY = actual.CancelButton.Top;
            actual.Size = new System.Drawing.Size(actual.Size.Width * 2, actual.Size.Height * 2);
            actual.OnResize();
            Assert.AreNotEqual(actual.CancelButton.Top, originalY);
        }

        // Use this whenever you need to access something that's only "protected " visibility
        class TestChrysalisForm : ChrysalisForm
        {
            public void OnLoad()
            {
                base.OnLoad(EventArgs.Empty);
            }

            public void OnResize()
            {
                base.OnResize(EventArgs.Empty);
            }

            public void ClickCancel()
            {
                base.ClickCancel();
            }

            public Button CancelButton {  get { return this.btnCancel; } }
        }
    }
}
