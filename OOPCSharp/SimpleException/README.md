Exceptions should be thrown **only when a more terminal condition** has been met (e.g., not finding a necessary file, failing to connect to a database, and the like) and **not used as a logic flow** mechanism.

A **try** block is a section of statements that may throw an exception during execution. If an exception is detected, the flow of program execution is sent to the appropriate **catch** block.
