using BugPro;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BugTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckNewState()
        {
            Bug bug = new();
            Assert.IsTrue(bug.CurrentState == Bug.State.NewBug);
        }
        [TestMethod]
        public void InvalidActions()
        {
            Bug.Action[] actions =
                [Bug.Action.ProblemSolved,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemNeedsMoreResources,
                    Bug.Action.Reopen];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.NewBug);
        }
        [TestMethod]
        public void OpenWork()
        {
            Bug.Action[] actions =
                [Bug.Action.Start];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void StartSolving()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.FixingBug);
        }
        [TestMethod]
        public void Solve()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemSolved,
                    Bug.Action.ProblemSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.Fixed);
        }
        [TestMethod]
        public void Loop()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemSolved,
                    Bug.Action.ProblemNotSolved];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void TooHard()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.TooHard);
        }
        [TestMethod]
        public void SolveAndReopen()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void Ignore()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemIgnored,
                    Bug.Action.ProblemIgnored];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.NotABug);
        }
        [TestMethod]
        public void IgnoreWithExtraSteps()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.NotABug);
        }
        [TestMethod]
        public void TooHardButNotAnymore()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.FixingBug);
        }
        [TestMethod]
        public void Chaos()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.TooHard);
        }
        [TestMethod]
        public void InvalidActions2()
        {
            Bug.Action[] actions =
                [Bug.Action.Start,
                    Bug.Action.ProblemNotSolved,
                    Bug.Action.Reopen,
                    Bug.Action.Start];
            Bug bug = new();
            for (int i = 0; i < actions.Length; i++)
            {
                bug.TakeAction(actions[i]);
            }
            Assert.IsTrue(bug.CurrentState == Bug.State.StudyingBug);
        }
        [TestMethod]
        public void DoubleSolve()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.Fixed);
        }
        [TestMethod]
        public void SolveThenIgnore()
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
            Assert.IsTrue(bug.CurrentState == Bug.State.NotABug);
        }
    }
}
