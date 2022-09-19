import unittest
import pytest

from Receiver.ConsoleReceiver.cr import ConsoleReceiver


class TestConsoleReceiver(unittest.TestCase):
    def setUp(self) -> None:
        self.sample_input = ["Temperature Reading, State Of Charge Reading",
                             "166, 67",
                             "20, 73",
                             "172, 70",
                             "16, 66",
                             "141, 13",
                             "38, 53",
                             "24, 28"]

        self.console_reader = ConsoleReceiver(self.sample_input)

    def test_initialization(self):
        self.assertEqual(len(self.sample_input), 8)

    def test_get_headers(self):
        col_1, col_2 = self.console_reader.get_headers()

        self.assertEqual(col_1, "Temperature Reading")
        self.assertEqual(col_2, "State Of Charge Reading")

    def test_column_values_0(self):
        col_1_values = self.console_reader.get_column_values(0)

        self.assertEqual(col_1_values, [166, 20, 172, 16, 141, 38, 24])

    def test_column_values_1(self):
        col_2_values = self.console_reader.get_column_values(1)

        self.assertEqual(col_2_values, [67, 73, 70, 66, 13, 53, 28])

    def test_get_max_values(self):
        self.assertEqual(self.console_reader.get_max_value([1, 2, 3, 4, 5, 6]), 6)

    def test_get_min_values(self):
        self.assertEqual(self.console_reader.get_min_value([1, 2, 3, 4, 5, 6]), 1)

    def test_get_sma(self):
        self.assertEqual(self.console_reader.get_simple_moving_average([1, 2, 3, 4, 5, 6], n=3), 5)

    def test_get_sma_invalid(self):
        self.assertEqual(self.console_reader.get_simple_moving_average([1, 2, 3, 4, 5, 6], n=10),
                         "Value of 'n' cannot be greater than values length")

    def test_process_data(self):
        result = self.console_reader.process_data()

        assert result['Temperature Reading'] == [172, 16, 78.2]
        assert result['State Of Charge Reading'] == [73, 13, 46.0]




