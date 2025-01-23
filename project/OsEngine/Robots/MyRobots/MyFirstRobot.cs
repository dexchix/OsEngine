using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsEngine.Entity;
using OsEngine.OsTrader.Panels;
using OsEngine.OsTrader.Panels.Attributes;

namespace OsEngine.Robots.MyRobots
{
    [Bot("MyFirstRobot")]
    public class MyFirstRobot : BotPanel
    {
        public MyFirstRobot(string name, StartProgram program) : base(name, program)
        {
            
        }

        public override string GetNameStrategyType()
        {
            return "MyFirstRobot";
        }

        public override void ShowIndividualSettingsDialog()
        {
            throw new NotImplementedException();
        }
    }
}
