using ErtuncMarsRobot.Commands;
using ErtuncMarsRobot.Robots;
using System;

namespace ErtuncMarsRobot.Actions
{
    public class ActionProvider : IAction
    {
        private IAction actionService { get; set; }
        public ActionProvider(Command command)
        {
            var namespaceName = string.Format("ErtuncMarsRobot.Actions.Action{0}", command.ToString());
            var type = Type.GetType(namespaceName);
            actionService = (IAction)Activator.CreateInstance(type);
        }

        public Result<Robot> DoAction(RobotAction robotAction)
        {
           return actionService.DoAction(robotAction);
        }
    }
}
