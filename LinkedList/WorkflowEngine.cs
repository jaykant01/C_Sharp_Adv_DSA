namespace LinkedList;

public interface IWorkflowStep
{
    void Execute();
}

public class WorkflowEngine
{
    class Node
    {
        public IWorkflowStep step;
        public Node next;

        public Node(IWorkflowStep step)
        {
            this.step = step;
            this.next = null;
        }
    }

        private Node head;

        public void AddStep(IWorkflowStep step)
        {
            Node newNode = new Node(step);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = newNode;
        }

        // Remove
        public void RemoveFirstStep()
        {
            if (head == null) return;
            head = head.next;
        }

        // Execute workflow
        public void Run()
        {
            if (head == null)
            {
                Console.WriteLine("Workflow is empty");
                return;
            }

            Node curr = head;
            while (curr != null)
            {
                curr.step.Execute();
                curr = curr.next;
            }
        }
    


}


class ValidateStep : IWorkflowStep
    {
        public void Execute()
        {
            Console.WriteLine("Validating document");
        }
    }

    class ReviewStep : IWorkflowStep
    {
        public void Execute()
        {
            Console.WriteLine("Reviewing document");
        }
    }

    class ApproveStep : IWorkflowStep
    {
        public void Execute()
        {
            Console.WriteLine("Approving document");
        }
    }
