using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cureos.Measures;
using Cureos.Measures.Quantities;
using System.Reflection;

namespace cureos.uomnet.tests.winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<String, Type> _typesDict;

        private void button1_Click(object sender, EventArgs e)
        {
            if (_typesDict == null)
            {
                _typesDict = new Dictionary<string, Type>();
                Type[] types = GetTypesInNamespace(Assembly.GetAssembly(typeof(Cureos.Measures.QuantityDimension)), "Cureos.Measures.Quantities");
                foreach (Type t in types)
                {
                    _typesDict.Add(t.Name, t);
                }
            }

            List<String> names = new List<string>();
            foreach (var a in _typesDict.Keys)
            {
                names.Add(a);
            }
            names.Sort();

            this.listBox_MeasurementTypes.Items.Clear();
            this.listBox_MeasurementTypes.Items.AddRange(names.ToArray());
        }

        private void listBox_MeasurementTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox_UnitsFrom.Items.Clear();
            this.listBox_UnitsTo.Items.Clear();

            if (this.listBox_MeasurementTypes.SelectedItems.Count != 1) return;

            String typeName = (String)this.listBox_MeasurementTypes.SelectedItem;
            Type type = _typesDict[typeName];
            foreach (FieldInfo fi in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                String name = fi.Name;

                this.listBox_UnitsFrom.Items.Add(name);
                this.listBox_UnitsTo.Items.Add(name);
            }
        }

        static private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }

        static private Type GetFieldType(Type type, String fieldInfoName)
        {
            foreach (FieldInfo fi in type.GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                if (String.Equals(fi.Name, fieldInfoName))
                {
                    return fi.FieldType;
                }
            }

            return type;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // convert from left to right
            String typeName = (String)this.listBox_MeasurementTypes.SelectedItem;
            String unitFromName = (String)this.listBox_UnitsFrom.SelectedItem;
            String unitToName = (String)this.listBox_UnitsTo.SelectedItem;
            Double from = (Double)this.numericUpDown1.Value;

            Type quantityType = _typesDict[typeName];
            Object a = Activator.CreateInstance(quantityType);
            Type unitFromType = GetFieldType(quantityType, unitFromName);
            Type unitToType = GetFieldType(quantityType, unitToName);

            // HELP: this won't compile
            //Double to = DoConversion<quantityType>(from, Activator.CreateInstance(unitFromType), Activator.CreateInstance(unitToType));

            // silly workaround: I added static method to Temperature struct:
            /*
             * // F
                public static readonly Unit<Temperature> Fahrenheit = new Unit<Temperature>("°F",
                                a => (a + 459.67) * 5 / 9, a => a * 9 / 5 - 459.67);

                public static IUnit<Temperature> GetUnit(string name)
                {
                    if (string.Equals(name, "Kelvin")) return Kelvin;
                    else if (string.Equals(name, "Celsius")) return Celsius;
                    else if (string.Equals(name, "Fahrenheit")) return Fahrenheit;
                    else return null;
                }
             * /
            */
            if (typeName == "Temperature")
            {
                Double to = DoConvert<Temperature>(from, Temperature.GetUnit(unitFromName), Temperature.GetUnit(unitToName));
                this.numericUpDown2.Value = System.Convert.ToDecimal(to);
            }
        }

        private Double DoConvert<Q>(Double from, IUnit<Q> unitFrom, IUnit<Q> unitTo) where Q : struct, IQuantity<Q>
        {
            var f = new Measure<Q>(from, unitFrom);
            return f.GetAmount(unitTo);
        }
    }
}
