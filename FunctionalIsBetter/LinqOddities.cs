using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FunctionalIsBetter
{
    [TestFixture]
    public class LinqOddities
    {
        [Test]
        public void TheDisappearingChange()
        {
            var reciept = new List<LineItem>
                {
                    new LineItem
                        {
                            Id = 1,
                            Name = "Pizza",
                            Value = 8.99
                        },
                    new LineItem
                        {
                            Id = 2,
                            Name = "Hot Dogs",
                            Value = 4.99
                        }
                };

            var selectableReceipt = reciept.Select(x =>
                                                   new SelectableItem
                                                       {
                                                           Id = x.Id,
                                                           Name = x.Name,
                                                           Selected = false,
                                                           Value = x.Value
                                                       });

            var selectedItem = selectableReceipt.First(x => x.Id == 1);
            selectedItem.Selected = true;

            Assert.That(selectableReceipt.Count(x => x.Selected == true), Is.EqualTo(1));
        }
    }

    public class SelectableItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool Selected { get; set; }
    }

    public class LineItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }

}
