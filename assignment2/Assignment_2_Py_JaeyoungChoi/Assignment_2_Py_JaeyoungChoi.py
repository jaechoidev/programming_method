def main():
    first_name = input("Enter your first name : ")
    last_name = input("Enter your last name : ")
    id_number = input("Enter your ID number : ")

    login_name = get_login_name(first_name, last_name, id_number)

    print(f"Your Login Name is {login_name}.")
    
    while(True):
        password = input("Enter your Password (at least 7 characters, one uppercase letter, one lowercase letter and one digit) : ")
        result = verify_password(password)
        if result == "passed":
            break
        else:
            print(result)

    print(f"You are successfully registered as {login_name}.")
    

def get_login_name(first_name, last_name, id_number):
    name_01 = first_name if len(first_name)<3 else first_name[:3]
    name_02 = last_name if len(last_name)<3 else last_name[:3]
    name_03 = id_number if len(id_number)<3 else id_number[-3:]

    return name_01+name_02+name_03

def verify_password(password):
    if len(password) < 7 :
        return f"Password should be longer than 7 characters. Now it is {len(password)} characters."
    if not any(char.isdigit() for char in password):
        return f"Password should have at least one digit."
    if not any(char.isupper() for char in password):
        return f"Password should have at least one uppercase letter."
    if not any(char.islower() for char in password):
        return f"Password should have at least one lowercase letter."
    
    return "passed"


main()



