
class ConsoleReceiver:
    def __init__(self, console_data):
        self.lines = console_data

    def get_headers(self):
        col_1, col_2 = self.lines[0].split(", ")
        return col_1, col_2

    def get_column_values(self, column_idx=0):
        values = []
        lines = self.lines[1:]

        for line in lines:
            values.append(int(line.split(", ")[column_idx]))

        return values

    def get_max_value(self, values):
        return max(values)

    def get_min_value(self, values):
        return min(values)

    def get_simple_moving_average(self, values, n=5):
        if n > len(values):
            return "Value of 'n' cannot be greater than values length"

        return sum(values[-n:]) / n

    def process_data(self):
        column_1, column_2 = self.get_headers()

        column_1_values = self.get_column_values(0)
        column_2_values = self.get_column_values(1)

        column_1_max = self.get_max_value(column_1_values)
        column_1_min = self.get_min_value(column_1_values)
        column_1_sma = self.get_simple_moving_average(column_1_values, 5)

        column_2_max = self.get_max_value(column_2_values)
        column_2_min = self.get_min_value(column_2_values)
        column_2_sma = self.get_simple_moving_average(column_2_values, 5)

        result = {column_1: [column_1_max, column_1_min, column_1_sma],
                  column_2: [column_2_max, column_2_min, column_2_sma]}

        return result










