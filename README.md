IBNet
=====

IBNet is an enhancement of Interactive Brokers C# API. Uses IB TWS API 10.30.1

## Features
**[Enumerations](https://github.com/zdomokos/IBNet/tree/master/IBNet/Enums):** Provides typed enumerations.

**[Concreate contracts](https://github.com/zdomokos/IBNet/tree/master/IBNet/Contracts):** Implements concrete contracts for different asset classes: 
stocks, options, futures, and forex.

**[Event Handling](https://github.com/zdomokos/IBNet/tree/master/IBNet/Messages):** Implements events for EWrapper callbacks. 

**[IB Flex Reports](https://github.com/zdomokos/IBNet/tree/master/IBNet/Flex/IbFlexReader):** Provides functionality to handle IB Flex Reports.

## Installation
To install IBNet, clone the repository and build the solution:

```git
git clone https://github.com/zdomokos/IBNet.git
cd IBNet
dotnet build
```

## Usage
See examples in the TestApp directory for how to use the API. The TestApp project contains sample 
code demonstrating how to connect to Interactive Brokers, request market data, and handle events.

## Contributing
We welcome contributions! Please follow these steps:

Fork the repository.
Create a new branch (git checkout -b feature-branch).
Make your changes.
Submit a pull request.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

