def can_see_stage(seats):
	rows = len(seats)
	columns = len(seats[0])
	prevSeat = -1
	for j in range(columns):
		for i in range(rows):
			if (i != 0):
				if (seats[i][j] <= prevSeat):
					return False
			prevSeat = seats[i][j]
	return True

print(can_see_stage([[1, 2, 3], [4, 5, 6], [7, 8, 9]]))
print(can_see_stage([[0, 0, 0], [1, 1, 1], [2, 2, 2]]))
print(can_see_stage([[2, 0, 0], [1, 1, 1], [2, 2, 2]]))
print(can_see_stage([[1, 0, 0], [1, 1, 1], [2, 2, 2]]))
