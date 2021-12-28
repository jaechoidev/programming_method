
def main():    
    f = open("Codes.txt", "r")
    result = dict()
    for code in f:
        code = code.strip()
        if result.get(validate_code(code)):
            result[validate_code(code)] += [code]
        else:
            result[validate_code(code)] = [code]
    print_result(result)

        
def validate_code(code):
    code_length = len(code) >= 10
    code_country = all(char.isdigit() for char in code[3:7])
    code_security = code[9].isupper()
    code_security_r = code[9] == "R"

    # one of the validations is failed.
    if not (code_length and code_country and code_security):
        return "Invalid"

    # vaildation is okay but restricted level of security in the target country.
    if code_country and code_security_r and int(code[3:7])>=2000:
        return "Restricted"
    
    return "Valid"

def print_result(result):
    print ("=" * 40)
    print("Valid Code(s) are:")
    for code in result["Valid"]:
        print(code)
    print ("=" * 40)

    print("Invalid Code(s) are:")
    for code in result["Invalid"]:
        print(code)
    print ("=" * 40)
    
    print("Invalid Restricted Code(s) are:")
    for code in result["Restricted"]:
        print(code)
    print ("=" * 40)

main()
