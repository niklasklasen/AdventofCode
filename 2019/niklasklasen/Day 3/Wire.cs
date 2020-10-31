using System;

namespace Day_3
{
    class Wire
    {
        public Wire(string name)
        {
            Name = name;
        }

        public Path()
        {

        }
        public string Name;
    }
}

/*
Path:
R = x += 1
L = x -= 1
U = y += 1
D = y -= 1

Posution[i] = x, y
ex position[0] = 0, 0
position[23] = 3452, 2466
*/