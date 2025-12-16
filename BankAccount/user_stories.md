
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

- AC001: I can go into the app to view a bank statement. I can provide a start date and end date. The statement shows me the following information:
    - All transactions within this period (inclusive)
    - I can see the start and end balance of the account for this period.

- AC002: For each transaction, the following information is shown:
    - The value
    - If it was a deposit or withdrawal
    - The datetime when the transaction occurred
    - The value of the account before the transaction
    - The value of the account after the transaction

Questions:

- How will you represent if the transaction is a deposit or withdrawal in the database?

Notes:

    MoSCoW - Used to prioritise User Stories
        - Must Have, Should Have, Could Have, Want/Would like

    Types of Foreign Key relations:
    -One to many
    -many to many (M2M)