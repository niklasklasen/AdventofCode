import array


def ReadValueInPosition(pos, mem):
    assert (pos < len(mem)) , "pos must be in ram"
    assert (pos >= 0), "pos must not be negative"
    return mem[pos]

def SetValueInPosition(value, pos, mem):
    assert (pos < len(mem)) , "pos must be in ram"
    assert (pos >= 0), "pos must not be negative"
    mem[pos] = value
    return value

def ReadOptcode(pos, mem):
    output = array.array('I')
    output.append(ReadValueInPosition(pos, mem))
    output.append(ReadValueInPosition(pos + 1, mem))
    output.append(ReadValueInPosition(pos + 2, mem))
    output.append(ReadValueInPosition(pos + 3, mem))
    return output

def ExecuteOptcode(pos, mem):
    opt = ReadOptcode(pos, mem)
    
    if opt[0] == 1:
        result = ReadValueInPosition(opt[1], mem) + ReadValueInPosition(opt[2], mem)
        SetValueInPosition(result, opt[3], mem)

    elif opt[0] == 2:
        result = ReadValueInPosition(opt[1], mem) * ReadValueInPosition(opt[2], mem)
        SetValueInPosition(result, opt[3], mem)

    elif opt[0] == 99:
        return False

    else :
        print("Out of bounds! (This is bad)")
        return False

    return True

        



