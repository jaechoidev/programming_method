# Assignment_1_Python : Jaeyoung Choi (T00677121)

def get_future_value(present_value, m_interest, num_of_months):
    return present_value * pow((1+m_interest), num_of_months)

print ("=" * 40)
present_value = float(input("Enter the account's present value : "))
m_interest = float(input("Enter monthly interest rate (%) : ")) / 100.0
num_of_months = int(input("Enter the number of months that the money will be left in the account : "))
future_value = get_future_value(present_value, m_interest, num_of_months)
print ("=" * 40)

print(f"The present money, ${present_value}, will be ${future_value:.2f} after {num_of_months} months.")

