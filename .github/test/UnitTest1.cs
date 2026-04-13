
using bugs;

namespace lab04_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bug.Action[] actions = 
                [Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemNotSolved, 
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.Reopen];
            Bug bug = new();
            for (int i=0;i<actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.NewBug);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.Reopen];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.TooHard);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemSolved,
                    Bug.Action.ProblemSolved,
                    Bug.Action.ProblemSolved,
                    Bug.Action.Reopen];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.Fixed);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemSolved, 
                    Bug.Action.Reopen, 
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.ProblemIgnored];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.NotABug);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.FixingBug);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Bug.Action[] actions =
                [Bug.Action.ProblemSolved,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.Reopen, 
                    Bug.Action.Start, 
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemSolved, 
                    Bug.Action.Reopen, 
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.Start];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.TooHard);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.Reopen, 
                    Bug.Action.Start];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.Start,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemSolved,
                    Bug.Action.ProblemNotSolved, 
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.Start, 
                    Bug.Action.Reopen, 
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.Fixed);
        }
        [TestMethod]
        public void TestMethod10()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.ProblemSolved,
                    Bug.Action.Reopen, 
                    Bug.Action.ProblemIgnored, 
                    Bug.Action.ProblemNotSolved, 
                    Bug.Action.ProblemNeedsMoreResources, 
                    Bug.Action.ProblemSolved, 
                    Bug.Action.ProblemIgnored];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Bug.State result = bug.CurrentState;
            Assert.IsTrue(result == Bug.State.NotABug);
        }
    }
}
