const string input = "[()]{}{[()()]}";
Stack<char> stack = new Stack<char>(); 
bool balanced = true; 

foreach(char c in input)
{
    if(c == '[' || c == '{' ||  c == '(')
    {
        stack.Push(c); 
    }

    else
    {
        char start = stack.Pop();
        if(
            (c == ')' && start != '(') ||
            (c == ']' && start != '[') ||
            (c == '}' && start != '{') 
        )
        {
            balanced = false;
            break;
        }
    }
}

if(balanced)
{
    Console.WriteLine("String is balanced");
}

else{
    Console.WriteLine("String is not balanced");
}
