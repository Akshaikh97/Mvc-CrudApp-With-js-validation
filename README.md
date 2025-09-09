🔹 Constructor
👉 Special method to initialize an object.
Types:
	• Private → Only in same class
	• Static → For static content
	• Default → Without params
	• Parameterized → With params

🔹 Inheritance
	• Single → 1 base, 1 derived
	• Hierarchical → 1 base, many derived
	• Multilevel → Derived from derived
	• Multiple → Implements multiple interfaces

🔹 Polymorphism
	• Compile Time (Overloading) → Same name, diff. params
	• Run Time (Overriding) → Child overrides parent method

🔹 Abstraction
Hide implementation using abstract or interface.

🔹 Interface
Defines contract, can have default implementation (C# 8).

🔹 Encapsulation
Keep fields private, use public properties.

🔹 Interface vs Abstract
	• Interface → Only contract
	• Abstract → Contract + some common code
👉 Real life: HR (knows only skills) → Interface
👉 Interviewer (knows details) → Abstract

🔹 Extension Method → Add new feature without modifying class.

🔹 Delegate → Stores methods as variable, invoke later.

🔹 Reflection → Inspect/modify objects at runtime.
✅ Extension → Compile time
✅ Delegate → Runtime logic
✅ Reflection → Dynamic runtime

🔹 Function vs Delegate
Function = Fixed code
Delegate = Variable holding methods

🔹 Const vs ReadOnly
	• Const → Fixed, never changes
	• Readonly → Can change only in constructor
🔹 Ref vs Out
	• ref → Pass by reference (input/output)
	• out → Only for returning multiple values
🔹 == vs .Equals()
	• == → Reference check
	• .Equals() → Content check
🔹 is vs as
	• is → Check type
	• as → Type casting

🔹 Value Type → int, float, bool, struct (Stack)
🔹 Reference Type → string, class, object (Heap)
🔹 String vs StringBuilder
	• string → Immutable
	• StringBuilder → Mutable (better for multiple ops)

🔹 Boxing / UnBoxing
int → object (Boxing)
object → int (UnBoxing)

🔹 Generics
Class/Method for any type with type safety.
🔹 Try-Catch
Multiple catch blocks for diff exceptions.

🔹 Important Keywords
	• base → Access parent
	• virtual → Can override
	• override → New implementation
	• new → Hide parent member
	• sealed → Stop inheritance
	• abstract → Force implementation
	• static → Without object
	• partial → Split class in files
	• async/await → Async methods
	• volatile → Multi-thread safe
	• ref/out/in → Param behavior
	• this → Current instance
	• params → Variable arguments
	• event → Pub-Sub pattern

🔹 Convert.ToString() vs .ToString()
	• Convert.ToString() → Handles null (returns "")
	• .ToString() → Throws exception on null

🔹 SOLID Principles
*Single Open Liskov Interfaces Depend principle
✅ S – Single Responsibility Principle (SRP)
➡️ A class should have only one responsibility or reason to change.

✅ O – Open/Closed Principle (OCP)
➡️ We should be able to add new functionality by extending existing code, without breaking existing behavior.

✅ L – Liskov Substitution Principle (LSP)
➡️ The child class should behave in a way that doesn’t break the expectations set by the parent class.

✅ I – Interface Segregation Principle (ISP)
➡️ Clients should not be forced to depend on interfaces they do not use.

✅ D – Dependency Inversion Principle (DIP)
➡️ We rely on abstractions instead of concrete implementations to achieve loose coupling and flexibility.
------------------------------------------------------------------------------------
Entity Framework
------------------------------------------------------------------------------------
IEnumerable: .ToList() returns a List<T>, and List<T> implements IEnumerable<T>
IQueryable / IEnumerable:
var query = dbContext.Users.Where(u => u.IsActive);   // IQueryable (query not executed yet)
var list = query.ToList();                            // Now executed, data in memory
IEnumerable<User> result = list;                      // This is IEnumerable


------------------------------------------------------------------------------------
MVC
------------------------------------------------------------------------------------
🔹 Dependency Injection (DI)
👉 Pass dependencies via constructor instead of creating inside class.
Types of DI:
	• Transient → New instance every call (e.g., API call)
	• Scoped → Same instance per request (e.g., maintain state)
	• Singleton → One instance for app lifetime (e.g., DB call)

🔹 Middleware
👉 Component between request & response (logging, error handling, etc.)
	• Use → Add middleware, request passes to next
	• Run → Terminal middleware, stops pipeline
	• Map → Creates a separate branch of middleware for specific routes.
	• Filter → Runs before/after controller action
	• Middleware = Global level
	• Filter = Controller/Action level

🔹 ActionResult
Return type → decides response to client.
✅ Types → View, JSON, XML, Files

🔹 Razor View
	• Write C# code inside HTML (dynamic pages)
	• Razor Code → @ syntax for inline C#

🔹 View Files
	• _ViewStart.cshtml → Default layout for views
	• _Layout.cshtml → Common structure (header, footer, nav)
	• @RenderBody → Insert child view content in layout
	• @RenderPage → Include another view content in page
	• PartialView → Reusable view

🔹 Routing Types
	• Convention-based
	• Attribute-based

🔹 Pass Data from Controller → View
	• ViewBag → Dynamic object (same request)
👉 ViewBag.Name = "Kasim"
	• ViewData → Dictionary object (same request)
👉 ViewData["Name"] = "Kasim"
	• TempData → Stores data temporarily (across requests/redirects)
👉 TempData["Name"] = "Kasim"

🔹 Session Management
	• Stores temporary, user-specific data on server
	• Configure in Program.cs → enable middleware → access via HttpContext.Session
	• Uses → Login info, carts, multi-page forms
Where Stored?
	• Default = Server memory
	• Also possible → SQL Server, Redis, Distributed cache

--------------------------------------------------------------------
SQL
--------------------------------------------------------------------
*Differentiate between a HAVING CLAUSE and a WHERE CLAUSE.
->use WHERE to filter rows
use HAVING to filter groups.

*Comment on Transactions.
->Transactions are a set of steps done together as one task.

*What are COMMIT and ROLLBACK in SQL
COMMIT ends the current transaction, making its changes permanent, while ROLLBACK undoes the transaction.

*Differentiate between a primary key and a unique key
->Primary key doesn't allow NULLs, but unique key allows one NULL.
->By default, clustered index on the column are created by the primary key whereas nonclustered index are created by unique key. 

*Differentiate between DELETE and TRUNCATE.
-Truncate can not be rolled back while Delete can be.
- Truncate locks the whole table, while Delete locks each row.
-Truncate resets the Identity column counter, but Delete doesn't
-Truncate doesn't activate triggers, but Delete does. 

*What is difference between clustered and non clustered index?
->A table can have only one Clustered Index at a time which is created on primary key and can have more than one non clustered indexes (maximum up to 999)
->Non* clustered index is faster than clustered index because when we use DML statement on clustered index, performance issues may occurred since it has to update the index every time a DML statement is executed.

*Difference between ROW_NUMBER, ROW function?
ROW_NUMBER: assigns a unique number to each row.
RANK: can assign the same rank to rows with identical values in the ordering column(s).
ROW_NUMBER: has no gaps; it always increments by 1.
RANK: leaves gaps when there are ties.

*What is Trigger?
A trigger in SQL is a set of instructions that automatically runs when certain changes (like insert, update, or delete) happen to a table.

*What are cursors and when they are useful?
Cursors in SQL let you go through each row of a result set one at a time. 
They're handy when you need to work with data row by row, especially for tasks like complex calculations or updates that need individual attention for each row. 

*What are Magic tables in SQL Server?
Magic tables in SQL Server are special virtual tables, not physical ones, known as "Inserted" and "Deleted."
They're used with triggers to access rows that have been inserted, deleted, or updated.

*What is difference between stored procedure and user defined function?
Stored procedures can change table data, but user-defined functions cannot.

*What is a Linked Server?
A Linked Server is a way to connect and query a remote database server from a local one, allowing them to work together in a single group.

*What is a WITH(NOLOCK)?
WITH(NOLOCK) is used to unlock the data which is locked by the transaction that is not yet committed. This command is used before SELECT statement.

*What is an Index?
An index is performance tuning method of allowing faster retrieval of records from the table. An index creates an entry for each value and it will be faster to retrieve data.

*What are all the different types of indexes?
Unique Index.
This indexing does not allow the field to have duplicate values if the column is unique indexed. Unique index can be applied automatically when primary key is defined.
Clustered Index.
This type of index reorders the physical order of the table and search based on the key values. Each table can have only one clustered index.
NonClustered Index.
NonClustered Index does not alter the physical order of the table and maintains logical order of data. Each table can have 999 nonclustered indexes.

*What is subquery?
A subquery is a query within another query. The outer query is called as main query, and inner query is called subquery. SubQuery is always executed first, and the result of subquery is passed on to the main query.

*What is a constraint?
Constraint can be used to specify the limit on the data type of table. Constraint can be specified while creating or altering the table statement. Sample of constraint are.
NOT NULL
CHECK
DEFAULT
UNIQUE
PRIMARY KEY
FOREIGN KEY

*What is data Integrity?
Data integrity means making sure the data in a database is accurate and consistent. It's like making sure that the information in your database is reliable and correct.

*What is Auto Increment?
Auto Increment is like a self-increasing counter that assigns a unique number to each new row added to a table. 

What is the difference between Cluster and Non Cluster Index?
Clustered index: Reorganizes rows in the table for fast access but changes their physical order.
Non-clustered index: Creates a separate list for quick access without rearranging the rows.

What is Self Join?
A self-join compares values within the same table, using aliases to distinguish between them.

What is Cross Join?
Cross join combines each row from one table with every row from another table, resulting in a Cartesian product.

*What are aggregate and scalar functions?
Aggregate functions are used to evaluate mathematical calculation and return single values. This can be calculated from the columns in a table. 
Scalar functions return a single value based on the input value.
Example * .
Aggregate – max(), count – Calculated with respect to numeric.
Scalar – UCASE(), NOW() – Calculated with respect to strings.

*How can you create an empty table from an existing table?
Select * into studentcopy from student where 1=2

*Difference between SELECT INTO, INSERT INTO
The main difference is that "SELECT INTO" creates a new table based on the result set of a query, copying both data and structure, while "INSERT INTO" inserts data into an existing table.
-- SELECT INTO creates a new table based on the result set of a query
SELECT * INTO NewTable FROM ExistingTable WHERE Condition = 'Value';

-- INSERT INTO inserts data into an existing table
INSERT INTO ExistingTable (Column1, Column2) VALUES ('Value1', 'Value2');

*Explain query execution plan?
1 The optimizer available in SQL Server optimizes the code to be effectively executed.  
2 A query execution plan shows how this optimizer would run the query. 
3 Query execution plan can be viewed by :  
4 Using the Show Execution Plan option available in Query Analyzer, 
5 Displaying Estimated Execution Plan on the query dropdown menu,  
6 Use the SET SHOWPLAN_TEXT ON command before running a query and capturing the execution plan event in a SQL Server Profiler trace. 

*What is recursion? Is it possible for a stored procedure to call itself or recursive stored procedure?  How many levels of SP nesting is possible?
Recursion is when a stored procedure calls itself. Yes, it's possible for a stored procedure to call itself. The number of levels of nesting is determined by the setting 'sp_configure' 'nested triggers'. 
Stored procedures and managed code references can be nested up to 32 levels. 

*Differentiate between a Local and a Global temporary table?
-A local temporary table exists only for the duration of a connection or, if defined inside a compound statement, for the duration of the compound statement. 
-Global temporary tables (created with a double “##”) are visible to all sessions. 
-Global temporary tables are dropped when the session that created it ends, and all other sessions have stopped referencing it.

*What is CTE (Common Table Expression)?
-CTE (Common Table Expression) is a temporary result set that you can reference within a SELECT, INSERT, UPDATE, or DELETE statement.

*What is Scheduled job and how to create it?
	1. Connect to your database of SQL server in SQL Server Management Studio.
	2. On the SQL Server Agent. There you will find a Jobs folder. Right click on jobs and choose Add New.
	3. A New Job window will appear. Give a related name for the job.
	4. Click next on the "Steps" in the left menu. A SQL job can have multiple steps either in the form of SQL statement or a stored procedure call.
	5. Click on the "Schedules" in the left menu. A SQL job can contain one or more schedules. A schedule is basically the time at which sql job will run itself. You can specify recurring schedules also.
	• Using scheduled job you can also create alert and notifications.
	
*What is SQL Profiler?
SQL Server provides a graphical tool which helps system administrators to monitor T* SQL statements of Database Engine.

*What is REPLACE and STUFF function in SQL Server?
STUFF: This function is used to replace the part of string with some another string.
REPLACE: This function is used to replace all the occurrences of particular string by another string.

*What is collation?
Collation sets rules for sorting and comparing text, handling different languages and character sizes using ASCII values.

*What is Online Transaction Processing (OLTP)?
-Online Transaction Processing or OLTP manages transaction based applications which can be used for data entry and easy retrieval processing of data. This processing makes like easier on simplicity and efficiency. It is faster, more accurate results and expenses with respect to OTLP.
-Example – Bank Transactions on a daily basis.

Jaise ek baar ek project me ek report query bahut slow thi, toh humne execution plan check karke dekha ke full table scan ho raha tha. Humne proper index banaya aur query ko rewrite kiya, jisse memory usage aur execution time dono 70% tak reduce ho gaya.

----------------------------------------------------------------------------------------------
Angular
----------------------------------------------------------------------------------------------
✅ Angular Interview Notes

➤ Introduction
	• Angular is a JavaScript framework to build dynamic web apps.
	• Helps bind UI with JS model using binding techniques.
	• Used to build SPA (Single Page Applications).
	• Features: DI, HttpClient, Input/Output, Lazy Loading, Routing, Services.

➤ Basic Building Blocks
	1. Template – The HTML view.
	2. Component – Binds UI to data model.
	3. Modules – Group of components, pipes, services.
	4. Bindings – Communication between component and template.
	5. Directive – Modify DOM behavior.
	6. Services – Reusable business logic.
	7. DI (Dependency Injection) – Injects instances of classes where needed.

➤ Bindings
	• Interpolation – {{ value }}
	• Property Binding – [src]="imageUrl"
	• Event Binding – (click)="doSomething()"
	• Two-way Binding – [(ngModel)]="value"

➤ Directives
Types:
	• Structural – Changes DOM layout. (*ngIf, *ngFor, *ngSwitch)
	• Attribute – Changes DOM appearance. (ngClass, ngStyle)

➤ Decorator
	• Special metadata applied to classes (e.g., @Component, @NgModule, @Injectable)

➤ SPA (Single Page Application)
	• Loads main UI once.
	• Subsequent navigation happens without full page reload.

➤ Routing
	• Defines navigation in app using RouterModule.
	• Routes map path to components.
const routes = [
  { path: 'home', component: HomeComponent }
];
	• router-outlet – Placeholder where routed views are loaded.

➤ Lazy Loading
	• Modules loaded on-demand for better performance.
Steps:
	1. Create feature modules.
	2. Add separate routing for them.
	3. Use loadChildren in main routing.
	4. Use forRoot in main module and forChild in feature modules.

➤ Content Projection
	• Pass content from parent to child using <ng-content>.

➤ ViewChild vs ContentChild
Type	Accesses
ViewChild, ViewChildren	Elements from own template
ContentChild, ContentChildren	Elements projected from parent

➤ Lifecycle Hooks
	1. constructor – Class instantiation
	2. ngOnChanges – Fires when an input property changes.
	3. ngOnInit – Fires when the component is displayed for the first time.
	4. ngDoCheck – Runs every time Angular checks if something has changed in the component.
	5. ngAfterContentInit – ngAfterContentInit is called after Angular puts the parent’s content inside the child component using <ng-content>.
	6. ngAfterViewInit – Fires After view & child views initializes
	7. ngAfterViewChecked – Runs every time Angular looks for changes in the component’s template and its child components.
	8. ngOnDestroy – Cleanup before Angular destroys the component.

Short Explaination of Life Cycle hook:
constructor – class created
ngOnChanges – input property changed
ngOnInit – component displayed first time
ngDoCheck – Angular checks for changes
ngAfterContentInit – parent’s content inserted via <ng-content>
ngAfterViewInit – component view & child views initialized
ngAfterViewChecked – runs on every check of component & child views
ngOnDestroy – cleanup before destruction

➤ Constructor vs ngOnInit()
Constructor	   ngOnInit
TS feature	   Angular hook
No binding yet	   Binding done
DOM not ready	   DOM accessible
Use for DI setup	   Use for init logic

➤ HTTP Calls in Angular
Steps:
	1. Import HttpClientModule.
	2. Inject HttpClient.
	3. Use get, post, etc.
	4. Use subscribe() to consume.

➤ Http Interceptors
	• Add auth token
	• Centralized error handling
	• Modify requests/responses
	• Retry failed calls using RxJs

➤ Data Sharing Between Components
Method	Use
@Input()	Parent to child
@Output() + EventEmitter	Child to parent
Services	Any component
Routing	Data via params

➤ Pipes
Used to transform data in templates.
Examples:
	• uppercase, lowercase, date, currency
	• async – For observables
	• json, percent, titlecase, slice, i18nPlural, i18nSelect
Custom Pipe Example:
@Pipe({ name: 'square' })
export class SquarePipe implements PipeTransform {
  transform(value: number): number {
    return value * value;
  }
}

➤ RxJs (Reactive Extensions)
	• Observables: Represent async data stream.
	• Observer: Subscribes to observable.
	• Subscription: Used to unsubscribe from stream.
const sub = obs.subscribe(data => ...);
sub.unsubscribe();

➤ RxJs Operators
	• map, filter, merge, concat, from
	• debounceTime, distinctUntilChanged, pluck, delay

➤ RxJs vs Promises
RxJs	Promise
Streams	One value
Cancelable	Not cancelable
Operators	No operators
Multiple emits	One emit only

➤ Change Detection Strategy
	• Angular checks changes in data and updates view.
	• Default: Full tree detection.
	• OnPush: Detects only on input change/event.
	• Use OnPush for performance optimization.

➤ *TrackBy in ngFor
	• Used to optimize rendering.
*ngFor="let item of list; trackBy: trackByFn"

➤ Standalone Components (Angular 14+)
	• Components without a module.
@Component({
  standalone: true,
  ...
})

➤ Route Guards
	• Control navigation.
	Guard	Purpose
	CanActivate	Allow/deny access
	CanDeactivate	Prevent leaving page
	Resolve	Pre-fetch data
	CanLoad	Prevent lazy load

➤ Template vs Reactive Forms
🔹 Feature	🟢 Template-driven	🔵 Reactive
Approach	UI-based (HTML-first)	Code-based (TS-first)
Form Controls	Uses ngModel	Uses FormControl, FormGroup, FormBuilder
Suitable For	Simple forms	Complex & large forms
Validation	Inline via HTML attributes	In component via TS
Form Structure	Defined in template	Defined in component
Scalability	Hard to scale for large forms	Better for large and dynamic forms
Testing	Difficult to unit test	Easy to write unit tests
Control over data	Less programmatic control	Full programmatic control
Two-way binding	Uses [(ngModel)]	One-way via FormControl
Performance	Slightly slower in complex cases	More optimized
	
	
➤ Dynamic Component Loading
	• Load components at runtime using ViewContainerRef, ComponentFactoryResolver.

➤ State Management
	• For sharing state globally.
	• Options:
		○ BehaviorSubject in service
		○ NgRx (Redux pattern)

➤ Subject vs BehaviorSubject vs ReplaySubject
Type	Behavior
Subject	Emits after subscribe
BehaviorSubject	Emits latest value immediately
ReplaySubject	Emits last N values

➤ Zone.js
	• Angular uses it to track async events (like setTimeout, HTTP).
	• Automatically triggers change detection after async events.

➤ Optimization Techniques
	• OnPush strategy
	• trackBy in *ngFor
	• Lazy loading
	• Preloading strategies
	• ng build --prod (tree shaking)
	• Avoid unnecessary bindings

➤ Internationalization (i18n)
	• Support multiple languages using Angular's i18n tools.
	• Use translation files (xlf, json) or pipes (i18nPlural, i18nSelect)

➤ Testing in Angular
	• Tools: Jasmine + Karma
	• TestBed – Testing environment
	• spyOn – Mock functions
	• fakeAsync, tick() – For async testing

➤ Animations
	• Import @angular/animations
	• Use trigger, state, transition, animate
trigger('toggle', [
  state('open', style({ height: '100px' })),
  transition('open <=> closed', animate('300ms'))
])

➤ Angular CLI Commands
	• ng new – Create new project
	• ng serve – Run app
	• ng build --configuration production – Build for prod
	• ng test – Run unit tests
	• ng lint – Linting
	• ng update, ng add – For libraries

➤ SSR (Server-Side Rendering)
	• Use Angular Universal.
	• Server renders the first page — improves SEO & speed.
---------------------------------------------------------------------------
API, Entity Framework & LINQ 
---------------------------------------------------------------------------
🔹 Web API
What is Web API? → Framework to build HTTP services for web, mobile, and desktop apps using RESTful principles.
REST vs SOAP? → REST uses HTTP verbs (lightweight, JSON), SOAP uses XML protocols (heavy, enterprise).
HTTP Verbs? → GET (retrieve), POST (create), PUT (update/replace), PATCH (partial update), DELETE (remove).
What is RESTful API? → API following REST principles: stateless, cacheable, uniform interface, client-server architecture.
Status Codes? → 2xx (success), 3xx (redirect), 4xx (client error), 5xx (server error). → 200 (OK), 201 (Created), 400 (Bad Request), 401 (Unauthorized), 404 (Not Found), 500 (Internal Error).
Content Negotiation? → Client specifies preferred response format via Accept header (application/json, application/xml).
Versioning Strategies? → URL (/api/v1/), Query (?version=1), Header (Accept-Version), Media Type versioning.
API vs Web Service? → Web Service uses SOAP/XML, API is broader concept including REST/JSON.
Difference between ApiController and Controller? → ApiController: Auto model validation, no view support, JSON by default. → Controller: Manual validation, supports views, flexible return types.
What is Action Filter? → Executes code before/after action execution (authentication, logging, caching).
Global Exception Handling? → Use middleware or IExceptionFilter to catch unhandled exceptions globally.
Authentication vs Authorization? → Authentication (who you are), Authorization (what you can access).
JWT Token? → JSON Web Token: encoded user claims, stateless, contains header.payload.signature.
CORS (Cross-Origin Resource Sharing)? → Browser security feature allowing/blocking cross-domain requests, configured in startup.
Rate Limiting? → Restrict number of API calls per user/IP to prevent abuse and ensure fair usage.
API Gateway? → Single entry point managing routing, authentication, rate limiting, and load balancing for microservices.
Idempotent Methods? → GET, PUT, DELETE produce same result when called multiple times; POST is not idempotent.
Swagger/OpenAPI? → Documentation standard for REST APIs, auto-generates interactive API documentation.
Difference between Synchronous and Asynchronous API? → Sync: Client waits for response, blocks thread. → Async: Client continues processing, handles response later using async/await.

🔹 Entity Framework (EF)
What is Entity Framework? → ORM (Object-Relational Mapping) framework that maps database tables to .NET objects.
Code First vs Database First vs Model First? → Code First: Classes → Database, Database First: Database → Classes, Model First: Visual model → Database.
DbContext vs DbSet? → DbContext: Database connection session, DbSet: Collection of entities (table representation).
Lazy Loading vs Eager Loading vs Explicit Loading? → Lazy: Load on access (.Navigation), Eager: Load with Include(), Explicit: Manual Load().
What is Migration? → Version control for database schema changes, tracks and applies database updates.
Fluent API vs Data Annotations? → Fluent API: Configuration in OnModelCreating (flexible), Data Annotations: Attributes on properties (simple).
Change Tracking? → EF monitors entity changes (Added, Modified, Deleted) in DbContext for SaveChanges().
AsNoTracking()? → Disables change tracking for read-only queries, improves performance for large datasets.
First() vs FirstOrDefault() vs Single() vs SingleOrDefault()? → First: Exception if empty, FirstOrDefault: null if empty, Single: Exception if 0 or >1, SingleOrDefault: null if 0, exception if >1.
IEnumerable vs IQueryable? → IEnumerable: In-memory LINQ (LINQ to Objects), IQueryable: Database queries (LINQ to SQL).
N+1 Problem? → One query + N additional queries for related data; solve with Include() or projection.
What is Unit of Work pattern? → DbContext implements Unit of Work, maintains list of objects and commits all changes in single transaction.
Repository Pattern? → Abstraction layer between data access and business logic, makes testing easier.
Connection Pooling? → EF reuses database connections to improve performance and resource utilization.
EF Core vs EF 6? → EF Core: Cross-platform, lightweight, better performance; EF 6: Windows only, more features.
Global Query Filters? → Automatically apply WHERE clause to all queries for an entity (soft delete, multi-tenancy).
Shadow Properties? → Properties not in entity class but configured in EF model (audit fields, foreign keys).
Owned Entity Types? → Value objects that don't have identity, stored in same table as owner entity.
Split Queries? → Break complex queries with multiple includes into separate database queries using AsSplitQuery().
Bulk Operations? → EF Core 7+ supports ExecuteUpdate() and ExecuteDelete() for bulk operations without loading entities.

🔹 LINQ (Language Integrated Query)
What is LINQ? → Language Integrated Query: uniform syntax to query different data sources (objects, databases, XML).
LINQ Syntax Types? → Method Syntax: collection.Where(x => x.Age > 18), Query Syntax: from x in collection where x.Age > 18.
Deferred vs Immediate Execution? → Deferred: Query executes when enumerated (.Where), Immediate: Executes immediately (.ToList(), .Count()).
IEnumerable vs IQueryable in LINQ? → IEnumerable: In-memory (LINQ to Objects), IQueryable: External data sources with expression trees.
Select vs SelectMany? → Select: 1-to-1 mapping, SelectMany: Flattens nested collections (1-to-many).
Where vs First vs Single? → Where: Filters collection, First: Gets first element, Single: Gets only element (exception if 0 or >1).
Any() vs All() vs Contains()? → Any: At least one matches condition, All: Every element matches, Contains: Specific value exists.
GroupBy vs OrderBy? → GroupBy: Groups elements by key, OrderBy: Sorts elements by property.
Join vs GroupJoin? → Join: Inner join (matching records), GroupJoin: Left join with grouped results.
Skip vs Take? → Skip: Bypass first N elements, Take: Get first N elements (used for pagination).
Aggregate Functions? → Sum(), Count(), Average(), Min(), Max(), Aggregate() for custom operations.
Expression Trees? → Represent code as data structure, used by IQueryable providers to translate to SQL.
Let keyword in LINQ? → Introduces range variable for reusing computed values in query expressions.
Anonymous Types in LINQ? → Compiler-generated types for selecting subset of properties: new { Name, Age }.
Func vs Action vs Predicate? → Func: Returns value, Action: No return (void), Predicate: Returns bool.
PLINQ (Parallel LINQ)? → Executes LINQ queries in parallel using .AsParallel() for better performance on multi-core.
LINQ Performance Tips? → Use IQueryable for databases, avoid ToList() early, use Any() instead of Count() > 0.
DefaultIfEmpty()? → Returns default value if sequence is empty, useful for left outer joins.
Zip() function? → Combines two sequences element by element: seq1.Zip(seq2, (a,b) => a + b).
Union vs Concat vs Intersect vs Except? → Union: Unique combined elements, Concat: All elements, Intersect: Common elements, Except: Elements in first but not second.
Custom LINQ Extension Methods? → Create static methods with 'this' parameter: public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate).

🔹 Advanced/Senior Level Questions
EF Core Performance Optimization? → Use AsNoTracking(), projection (Select), split queries, compiled queries, and proper indexing.
LINQ Query Optimization? → Avoid premature materialization, use appropriate data structures, minimize database round trips.
Custom LINQ Provider? → Implement IQueryable<T> and IQueryProvider to translate expression trees to custom query language.
EF Core Interceptors? → Hook into EF operations (connection, command, transaction) for logging, auditing, or modification.
Memory Management in LINQ? → Use yield return for large datasets, dispose enumerators, avoid unnecessary ToList() calls.
Complex LINQ Queries Performance? → Break into smaller queries, use appropriate joins, consider raw SQL for complex scenarios.
EF Core Value Converters? → Convert between entity property types and database column types (enum to string, JSON serialization).
LINQ Expression Compilation? → Compile<TDelegate>() converts expression trees to executable delegates for better performance.
<img width="913" height="18916" alt="image" src="https://github.com/user-attachments/assets/370754cc-4fb7-4eab-8b3a-d000d60759a0" />
