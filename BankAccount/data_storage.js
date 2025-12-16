employee_data = {
  1: {
    "first_name": "Melita",
    "last_name": "Carty",
    "role": "Software Engineer",
  },
  2: {
    "first_name": "Bob",
    "last_name": "Smith",
    "role": "Software Engineer",
  },
}

employee_data["1"]["first_name"] = "Alice";

transactions = {
  1: {
    "value": "10",
    "date": "15-12-25",
    "time": "13:00",
    "type": "deposit",
  },
}

accounts = {
  1: {
    "name": "My Current Account",
    "type": "current account",
    "description": "This is my description",
    "transactions": {
      1: {
        "value": 10,
        "date": "15-12-25",
        "time": "13:00",
        "type": "deposit",
      },
      2: {
        "value": 10,
        "date": "15-12-25",
        "time": "13:00",
        "type": "deposit",
      },
    },
  },
}

// What database setup will we have to do before the app runs?

// create transactions table
// fields from the user story - columns
// no rows

// create account table
// fields from the user story

// assume that users is handled elsewhere - don't worry about that for now.
// our app just has one user

// What SQL queries will we have to do?
// Account - CREATE
// Transaction - CREATE, RETRIEVE

// CRUD
// create, retrieve, update, delete
// ==
// get, create, update, delete
