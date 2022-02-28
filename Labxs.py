customers = []
maxCustomers = 10
coffees = []
points = []
while len(customers) < maxCustomers:
    name = input('Enter your name:')
    coffee = input('Enter the amount of coffees you have ')
    customers.append(name)
    coffees.append(coffee)
    print(name)
    if coffee == '0':
        print('You have 0 points.')
        points.append('0')
    elif coffee == '1' or coffee == '2':
        print("You have 20 points.")
        points.append('20')
    elif coffee == '3' or coffee == '4':
        print('You have 45 points.')
        points.append('45')
    elif coffee == '5' or coffee == '6':
        print('You have 75 points.')
        points.append('75')
    elif coffee == '7' or coffee == '8':
        print('You have 110 points.')
        points.append('110')
    else:
        print('You have 150 points')
        points.append('150')
for i in range(0, len(points)):
    points[i] = int(points[i])
print('The total number of points for the store this month is: ', sum(points))
