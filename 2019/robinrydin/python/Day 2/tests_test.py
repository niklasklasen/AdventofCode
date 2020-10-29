from functions import *
import array
import unittest

class TestFunctions(unittest.TestCase):
    def test_ReadValue(self):
        mock = array.array('I')
        mock.append(42)
        self.assertEqual(ReadValueInPosition(0,mock), 42)
    def test_SetValue(self):
        mock = array.array('I')
        mock.append(42)
        self.assertEqual(SetValueInPosition(50,0,mock), 50)
        self.assertEqual(mock[0], 50)

    def test_Optcode(self):
        mock = array.array('I')
        mock.append(50)
        mock.append(51)
        mock.append(52)
        mock.append(53)
        
        result = ReadOptcode(0, mock)
        self.assertEqual(result[0], 50)
        self.assertEqual(result[1], 51)
        self.assertEqual(result[2], 52)
        self.assertEqual(result[3], 53)

    def test_execOptcodeAdd(self):
        mock = array.array('I')
        mock.append(1)
        mock.append(5)
        mock.append(6)
        mock.append(0)

        mock.append(99)
        mock.append(2000)
        mock.append(99435)
        
        result = ExecuteOptcode(0, mock)

        self.assertEqual(mock[0], 101435)
        self.assertEqual(result, True)

    def test_execOptcodeMult(self):
        mock = array.array('I')
        mock.append(2)
        mock.append(5)
        mock.append(6)
        mock.append(0)

        mock.append(99)
        mock.append(2)
        mock.append(3)
        
        result = ExecuteOptcode(0, mock)

        self.assertEqual(mock[0], 6)
        self.assertEqual(result, True)

    def test_execOptcodeStop(self):
        mock = array.array('I')
        mock.append(99)
        mock.append(5)
        mock.append(6)
        mock.append(0)

        mock.append(99)
        mock.append(2000)
        mock.append(99435)
        
        result = ExecuteOptcode(0, mock)

        self.assertEqual(mock[0], 99)
        self.assertEqual(result, False)




    
if __name__ == '__main__':
    unittest.main()