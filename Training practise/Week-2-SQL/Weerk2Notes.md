# Notes on SQL and the Topics

## DDL - Definition

- [Data-Definition-Language] - statements defines data structures. Use these statements to create, alter, or drop data structures in a database
- CREATE TABLE, ALTER TABLE, DROP TABLE, CREATE VIEW, DROP VIEW, CREATE, DROP
  - these commands handle whole database objects like tables without opening them up and handling individual rows.

## DML - Definitions

- [Data-Manipulation-Language](DML) -is a vocabulary used to retrieve and work with data in SQL Server and SQL Database
- affect the information stored in the database. Use these statements to insert, update, and change the rows in the database.
- SELECT, INSERT, UPDATE, DELETE, and debateably TRUNCATE TABLE
    -- these commands handle rows in tables.

## DDL - Columns(Data Type, Null, Not Null)

- A [data-type] is an attribute that specifies the type of data that the object can hold: integer data, character data, monetary data, date and time data, binary strings, and so on.

- [NULL] and [NOT-NULL] normally, by default, all columns can accept NULL as a possible value (and as their default).
- this can be explicitly marked by putting NULL after the column definition.
- it's good practice to always explicitly mark NULL or NOT NULL, because
- database settings and other circumstances could change the default of NULL.

- [NOT-NULL] prevents NULL, and leaves the column without a default value.

## DDL - Constraints(PK, FK, Unique, Check, Default, Identity)

- [UNIQUE] constraints and [CHECK] constraints are two types of constraints that can be used to enforce data integrity in SQL Server tables.

- [UNIQUE] constraints to make sure that no duplicate values are entered in specific columns that do not participate in a primary key.
  - Unlike PRIMARY KEY constraints, UNIQUE constraints allow for the value NULL. However, as with any value participating in a UNIQUE constraint, only one null value is allowed per column. A UNIQUE constraint can be referenced by a FOREIGN KEY constraint.

- [CHECK] constraints enforce domain integrity by limiting the values that are accepted by one or more columns.
  - CHECK constraints enforce domain integrity by limiting the values that are accepted by one or more columns.

- [DEFAULt]
- provide a different default to the column apart from NULL
- could be any expression, like calling functions, doesn't have to be constant/literal

- [UNIQUE]
- all the rows in this table must have unique values for that column.
- can also put it on multiple columns taken together, like (City,State)

- [IDENTITY]
- prevents manually setting the column's value; auto-incrementing value
- for each new row.

- [PRIMARY-KEY] -(the table will be stored in primary key order)
- implies NOT NULL and UNIQUE
- the column that will identify the row from the point of view of other rows.
- adds a clustered index by default on the column

- [FOREIGN-KEY]
- allow this column to reference another row, possibly in another table

## DML - Keywords(SELECT, INSERT, UPDATE, DELETE)

- [SELECT] - Retrieves rows from the database and enables the selection of one or many rows or columns from one or many tables in SQL Server.

- [INSERT] - Adds one or more rows to a table or a view in SQL Server.

- [UPDATE] - Changes existing data in a table or view in SQL Server.

- [DELETE] - Removes one or more rows from a table or view in SQL Server

## DML - Union Operations(UNION, UNION ALL, Intersect, Except)

- Concatenates the results of two queries into a single result set. You control whether the result set includes duplicate rows:
  - [UNION-ALL] - Includes duplicates.
    [UNION] - Excludes duplicates.
- A [UNION] concatenates result sets from two queries. But a UNION does not create individual rows from columns gathered from two tables.

- [EXCEPT] - returns distinct rows from the left input query that aren't output by the right input query.

- [INTERSECT] - returns distinct rows that are output by both the left and right input queries operator

## DML - Aggregation(COUNT, SUM, MAX, MIN, AVG)

- [COUNT] - This function returns the number of items found in a group. COUNT operates like the COUNT_BIG function. These functions differ only in the data types of their return values.

- [SUM] - Returns the sum of all the values, or only the DISTINCT values, in the expression. SUM can be used with numeric columns only. Null values are ignored.

- [MAX] - Returns the maximum value in the expression.

- [MIN] - Returns the minimum value in the expression. May be followed by the OVER clause.

- [AVG] -This function returns the average of the values in a group. It ignores null values.

## DML - Join Operations(CROSS, INNER, FULL OUTER, LEFT OUTER, RIGHT OUTER)

- A [JOIN] compares columns from two tables or, to create result rows composed of columns from two tables.

- [CROSS] - is used to generate a paired combination of each row of the first table with each row of the second table.

- [INNER] -selects all rows from both the tables as long as the condition satisfies

- [FULL-OUTER] - all rows from both the tables are included. If there are any unmatched rows, it shows NULL values for them.

- [LEFT-OUTER] - It gives the output of the matching row between both the tables. If no records match from the left table, it also shows those records with NULL values

- [RIGHT-OUTER] - It gives the output of the matching row between both the tables. If no records match from the right table, it also shows those records with NULL values

## DML - Subquery(FROM CLAUSE, WHERE CLAUSE, CTE)

- [FROM] clause is usually required on the SELECT statement. The exception is when no table columns are listed, and the only items listed are literals or variables or arithmetic expressions.

- [WHERE] - filters only the rows that are evaluated to true. If the condition evaluates to false or unknown, the rows will not be filtered causing an error.
  - locates which database/schema/table where a row is located
- [CTE] - Specifies a temporary named result set, known as a common table expression (CTE). This is derived from a simple query and defined within the execution scope of a single SELECT, INSERT, UPDATE, DELETE or MERGE statement. This clause can also be used in a CREATE VIEW statement as part of its defining SELECT statement. A common table expression can include references to itself. This is referred to as a recursive common table expression.

## DDL - Keywords(CREATE, ALTER, DROP, TRUNCATE, TABLE)

- [CREATE] - Creates a new table in SQL Server and Azure SQL Database.

- [ALTER] - Modifies a table definition by altering, adding, or dropping columns and constraints. ALTER TABLE also reassigns and rebuilds partitions, or disables and enables constraints and triggers.

- [DROP] - Removes one or more table definitions and all data, indexes, triggers, constraints, and permission specifications for those tables. Any view or stored procedure that references the dropped table must be explicitly dropped by using DROP VIEW or DROP PROCEDURE. To report the dependencies on a table, use

- [TRUNCATE]- Removes all rows from a table or specified partitions of a table, without logging the individual row deletions. TRUNCATE TABLE is similar to the DELETE statement with no WHERE clause; however, TRUNCATE TABLE is faster and uses fewer system and transaction log resources.

## DDL - Cascading, Indexes

- [CASCADE] - Corresponding rows are deleted from the referencing table if that row is deleted from the parent table.

- [Indexes]
- data structures that we can have sql server maintain during writes
- so that reads can be faster.
in SQL Server:
  - clustered index
    - tells sql server what order to 'physically' arrange the table in, can only be one by default, PRIMARY KEY sets CLUSTERED INDEX.
  - nonclustered index
    - maintains a separate data structure analogous to an index at the end of and enyclopedia we can have many of these.
    - UNIQUE sets nonclustered index by default

## DDL - Functions, Procedures

- [Functions] -Aggregate functions perform a calculation on a set of values and return a single value. They are allowed in the select list or the HAVING clause of a SELECT statement. You can use an aggregation in combination with the GROUP BY clause to calculate the aggregation on categories of rows. Use the OVER clause to calculate the aggregation on a specific range of value. The OVER clause cannot follow the GROUPING or GROUPING_ID aggregations.

- [Procedures] - A stored procedure in SQL Server is a group of one or more Transact-SQL statements or a reference to a Microsoft .NET Framework common runtime language (CLR) method. Procedures resemble constructs in other programming languages because they can:

Accept input parameters and return multiple values in the form of output parameters to the calling program.

Contain programming statements that perform operations in the database. These include calling other procedures.

Return a status value to a calling program to indicate success or failure (and the reason for failure).

- (stored) [procedures] are like functions, except you can
-- modify the DB, and you can't run them except with the EXECUTE statement.
-- also, they don't have return values, but they do have "out parameters"

## DDL - Triggers (For, Instead Of, After)

- [triggers]
- some code that will run instead of or after
- you insert, update, or delete to a particular table.

- idea from mark next time i teach this
- updates/inserts/deletes to a table require approval so trigger replaces them with inserts to the pending approvals table then the admin can come in and update Approved = 1, which a trigger transforms into applying the original operation to the first table.

- a trigger that automatically maintains the DateModified column for updates

- [FOR|AFTER]] - Use the FOR clause to specify one of the following options for query results.
  - Allow updates while viewing query results in a browse mode cursor by specifying FOR BROWSE.
  - Format query results as XML by specifying FOR XML.
  - Format query results as JSON by specifying FOR JSON.
- Specifies that the DML trigger launches instead of the triggering SQL statement, thus, overriding the actions of the triggering statements. You can't specify INSTEAD OF for DDL or logon triggers.

- [INSTEAD-OF] - Specifies that the DML trigger launches instead of the triggering SQL statement, thus, overriding the actions of the triggering statements. You can't specify INSTEAD OF for DDL or logon triggers.

## ADO.NET - Definition

- [ADO.NET] - is the core data access technology for .NET languages. Use the Microsoft.Data.SqlClient namespace to access SQL Server, or providers from other suppliers to access their stores. Use System.Data.Odbc or System.Data.Oledb to access data from .NET languages using other data access technologies. Use System.Data.Dataset when you need an offline data cache in client applications. It also provides local persistence and XML capabilities that can be useful in web services.

## ADO.NET - Connected, Disconnected Architectures

- [Connected] - As the name suggests, connected architecture refers to the fact that the connection is established for the full time between the database and application. For e.g. we make a program in C# that is connected with the database for the full time, so that will be connected architecture.
- Connected architecture is forward only and read-only. This means the connected mode will work only in one particular direction i.e. forward and that too for read-only purpose. Application issues query then read back results and process them.

- [Disconnected] - Disconnected architecture refers to the mode of architecture in Ado.net where the connectivity between the database and application is not maintained for the full time. Connectivity within this mode is established only to read the data from the database and finally to update the data within the database.
- This means during the processing of the application, we need data so that data is fetched from the database and kept in temporary tables. After that whenever data is required, it is fetched from the temporary tables. And finally, when the operations were completed, the connection was established to update the data within the database from the temporary tables.

## Transaction - Definition

- Transaction Control Language (TCL) manages transactions, whereby
- multiple statements can be encapsulated as one operation that
- either entirely succeeds or takes no effect at all.
- BEGIN TRANSACTION, COMMIT, ROLLBACK, SAVE TRANSACTION
- TCL Manages changes by which type of statements
- A [transaction] is a single unit of work. If a transaction is successful, all of the data modifications made during the transaction are committed and become a permanent part of the database. If a transaction encounters errors and must be canceled or rolled back, then all of the data modifications are erased.
- TCL Manages changes made by the DML

## Transaction - ACID

- [Atomicity] - means that a transaction either fully completes or not at all. It cannot be left in the middle in an inconsistent state

- [Consistency] - ensures that a transaction will always bring the database from one consistent state to another.

- [Isolation] - means that a transaction is isolated from other concurrent processes. It prevents concurrent processes from seeing the updates of an incomplete transaction.

- [Durability] - This property ensures that, as and when a transaction commits, it is made persistent so that even in a case of power failure or system crash after it is committed,

## Transaction - Isolation Levels (Read Uncommitted, Read Committed, Repeatable Read, Serializable)

[Read-Uncommitted] - Transactions running at this level do not issue shared locks to prevent other transactions from modifying data read by the current transaction.
[Read-Committed] - transactions issue exclusive locks at the time of data modification, thus not allowing other transactions to read the modified data that is not yet committed.
[Repeatable-Read ]- statements cannot read data that has been modified but not yet committed by other transactions.
[Serializable] - statements cannot read data that has been modified but not yet committed by other transactions. No other transactions can modify data that has been read by the current transaction until the current transaction completes.

## RDBMS - Data Modeling, ERD

An entity relationship diagram (ERD)