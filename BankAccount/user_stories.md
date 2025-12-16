
User Story 1 - Bank Account:

As a user of the app, I want to be able to have an account (one account for now)
- AC001: The account can have:
    - A name
    - Balance
    - Transactions (one to many)
    - Type (current account, easy access) - choice or a table?
    - Description - multiline text field

Questions:

- Which of the above fields should be required fields?

User Story 2 - Bank Statement:

As a user of the app, I want to be able to see a log of transactions (including deposits and withdrawals) like a bank statement.
- AC001: Each transaction includes the following information:
    - The value
    - The datetime when the transaction occurred
    - The value of the account before the transaction
    - The value of the account after the transaction

- AC002: I can go into the app and view a bank statement. I can provide two dates and all transactions between these dates (inclsive) are included. The statement shows me the following information:
    - For each transaction, I can see the value, datetime and if it was a deposit or withdrawal
    - I can see the start and end values of the account for this period.

Questions:

- How will you represent if the transaction is a deposit or withdrawal in the database?

Notes:

    MoSCoW - Used to prioritise User Stories
        - Must Have, Should Have, Could Have, Want/Would like

    Types of Foreign Key relations:
    -One to many
    -many to many (M2M)