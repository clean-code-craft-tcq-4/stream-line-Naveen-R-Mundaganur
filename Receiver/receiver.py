from Receiver.ConsoleReceiver.cr import ConsoleReceiver


def main():
    inp = []
    while True:
        line = input()

        if line:
            inp.append(line)
        else:
            break

    console_recv = ConsoleReceiver(inp)

    result = console_recv.process_data()

    for key, item in result.items():
        print(f"(Max, Min, SMA) values for {str(key)} are : {str(item[0])}, {str(item[1])}, {str(item[2])}")


if __name__ == '__main__':
    main()