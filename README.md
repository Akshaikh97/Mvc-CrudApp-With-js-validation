🔹 **Constructor**

👉 Special method to initialize an object.

**Types:**

- Private → Only in same class
- Static → For static content
- Default → Without params
- Parameterized → With params

🔹 **Inheritance**

Inheritance lets one class reuse the properties and methods of another.

- Single → 1 base, 1 derived
- Hierarchical → 1 base, many derived
- Multilevel → Derived from derived
- Multiple → Implements multiple interfaces

🔹 **Polymorphism**

Polymorphism means a single method can behave differently based on the object or data type it is working with.

- Compile Time (Overloading) → Same name, diff. params. Return type doesn't matter.
- Run Time (Overriding) → Child overrides parent method

🔹 **Abstraction**

Hide implementation using abstract class or interface.

🔹 **Interface**

Defines contract, can have default implementation (C# 8).

🔹 **Encapsulation**

We Keep fields private and use public properties to control access.

🔹 **Interface vs Abstract**

- Interface → Only contract(methods) not properties
- Abstract → Contract + some common code

👉 Real life: HR (knows only skills) → Interface

👉 Interviewer (knows details) → Abstract

![image.png](attachment:81825b52-71ee-4ed5-8853-f0a2f77469be:image.png)

| 🔑 **Major Point** | **Interface** | **Abstract Class** |
| --- | --- | --- |
| **🧱 Object Creation** | ❌ Object nahi ban sakta | ❌ Object nahi ban sakta |
| **🔧 Implementation** | ❌ Methods ke body nahi (except C# 8+ default) | ✅ Abstract + Concrete methods dono allowed |
| **♻️ Multiple Inheritance** | ✅ Allowed (multiple interfaces) 
Tricky Q: An interface can inherit from another interface, but an interface cannot inherit from a class. | ❌ Not allowed |
| **🧠 Use Case** | Contract chahiye (what to do) | Code reuse + rules (how + what to do) |
| **🏗 Constructors** | ❌ Nahi hote | ✅ Hote hain |
| **🔐 Access Modifiers** | ❌ Nahi de sakte (public by default) | ✅ De sakte ho (public, protected...) |
| **📦 Fields/Variables** | ❌ Nahi rakh sakte | ✅ Instance fields allowed |
| **🚀 Performance** | 🔺 Thoda fast (simple dispatch) | 🔻 Thoda slow (logic hone ki wajah se) |
| **📌 When to Use** | 🔹 Unrelated classes 
🔹 Plugins | 🔹 Related classes 🔹 Shared code reuse |

🔹 **Extension Method** → 

Add new feature without modifying class.

🔹 **Delegate** →
Stores methods as variable, invoke later.

🔹 **Reflection** →
Inspect/modify objects at runtime.

✅ Extension → Compile time

✅ Delegate → Runtime logic

✅ Reflection → Dynamic runtime

🔹 **Function vs Delegate**

Function = Fixed code

Delegate = Variable holding methods

🔹 **Const vs ReadOnly**

- Const → Fixed, never changes
- Readonly → Can change only in constructor

🔹 **Ref(matlab modifying) vs Out(matlab assigning)**

- ref → Pass by reference (input/output)

1.Value pehle se honi chahiye, method use read & modify kar sakta hai

2.Jab existing value ko modify karna ho (cart, balance, stats)

- out → Only for returning multiple values

1.Value pehle se nahi honi chahiye, method ko compulsory nayi value assign karni hoti hai.

2.New value assign karna (user ID, document number, order ID)

🔹 **== vs .Equals()**

- == → Reference check
- .Equals() → Content check

🔹 **is vs as**

- is → Check type
- as → Type casting

🔹 **Value Type(Primitive Data Types):
Store data directly into memory stack**

→int, float, bool, struct (Stack)

🔹 **Reference Type(Non-Primitive Data Types):
Store reference to memory location in heap**
→ string, class, object (Heap)

🔹 **String vs StringBuilder**

- string → Immutable
- StringBuilder → Mutable (better for multiple ops)

🔹 **Boxing / UnBoxing**

(Boxing) int → object

(UnBoxing) object → int

🔹 **Generics**

Using Generic we able to create Class/Method of any type.

🔹 **Try-Catch**

For catching validations we use try catch in functions, we can handle validations at Global level as well in Middleware(we can also write Multiple catch blocks for diff exceptions in one method).

🔹 **Important Keywords**

- base → Access parent
- virtual → Can override
- override → New implementation
- new → Hide parent member
- sealed → Stop inheritance
- abstract → Force implementation
- static → Without object
- partial → Split class in files
- async/await → Async methods
- volatile → Multi-thread safe
- ref/out/in → Param behavior
- this → Current instance
- params → Variable arguments
- event → Pub-Sub pattern

🔹 **Convert.ToString() vs .ToString()**

- Convert.ToString() → Handles null (returns "")
- .ToString() → Throws exception on null

🔹 **SOLID Principles**

- **S**ingle **O**pen **L**iskov **I**nterfaces **D**epend **principle**

**✅ S – Single Responsibility Principle (SRP)**

➡️ A class should have only one responsibility or
reason to change.

**✅ O – Open/Closed Principle (OCP)**

➡️ We should be able to add new functionality by
extending existing code, without breaking existing behavior.

**✅ L – Liskov Substitution Principle (LSP)**

➡️ The child class should behave in a way that
doesn’t break the expectations set by the parent class.

**✅ I – Interface Segregation Principle (ISP)**

➡️ Clients should not be forced to depend on interfaces they do not use.

**✅ D – Dependency Inversion Principle (DIP)**

➡️ We rely on abstractions instead of concrete
implementations to achieve loose coupling and flexibility.

---

## Entity Framework

IEnumerable: .ToList() returns a List<T>, and List<T> implements IEnumerable<T>
IQueryable / IEnumerable:
var query = dbContext.Users.Where(u => u.IsActive);   // IQueryable (query not executed yet)
var list = query.ToList();                            // Now executed, data in memory
IEnumerable<User> result = list;                      // This is IEnumerable

Explaination: IQueryable delays execution and queries the database, while IEnumerable works with in-memory data already loaded.

![image.png](attachment:d49b7f3e-7461-4de4-9a16-3342abd9a3ef:image.png)

- -----------------------------------------------------------------------------------

MVC

- -----------------------------------------------------------------------------------

🔹 **Dependency Injection (DI)**

👉 Pass dependencies via constructor, instead of creating them inside the class using `new` keyword.

// instead of creating object (yaha object se mera matlab hai `new Car()` jaha ham store karate hai)

`Car myCar = new Car();`

`Car` → class name

`myCar` → reference (naam) us object ka

`new Car()` → heap memory mein ek real object banata hai.

// constructor me reference `_car` daalke chhod dete hai, fir aage wo kahi bhi object (e.g. `new Car()`) ho sakta hai

```csharp
private readonly Car car;

public SomeController(Car _car)
{
	car = _car;
}

```

**Types of DI:**

- **Transient** → New instance created at every call (e.g., API call)
- **Scoped** → Same instance used per request (e.g., maintain state like “Shopping carts, multi-page forms”)
- **Singleton** → One instance for app lifetime (e.g., DB call, logging(eg: Serilog, NLog, Log4Net etc…), caching, file system service etc…)

🔹 **Middleware**

👉 It’s Component between request & response to handle task like(logging(eg: Serilog, NLog, Log4Net etc…),
error handling, Authentication, Authorization, Caching, Request/Response Modification, Rate Limiting, Session Management, Security Headers)

- **Logging:** Track every API request for debugging
- **Error Handling:** Catch and respond to errors gracefully
- **Authentication:** Verify user identity (e.g., JWT token check)
- **Authorization:** Check if user has access rights
- **Caching:** Store frequent responses to improve speed
- **Request/Response Modification:** Add custom headers or transform data
- **Rate Limiting:** Prevent abuse by limiting requests per IP
- **Session Management:** Manage user sessions with cookies/tokens
- **Security Headers:** Add headers like CSP, HSTS for protection

- **Use** → Adds middleware and lets the request pass to the next middleware.

**Use ka Khulasa:**

- Middleware ko pipeline me add karta hai
- Request jab aata hai, toh ye middleware apna kaam karta hai, fir **`next()`** middleware ko call karta hai
- Matlab: Request aage bhi jaa sakti hai, pipeline continue hota hai

**Code Explanation:**

app.Use(async (context, next) => {
Console.WriteLine("Before next middleware");
await next();  // aage ke middleware ko call karta hai
Console.WriteLine("After next middleware");
});

**code ka khulasa:**

Yaha, "Before next middleware" pehle print hoga, fir next middleware execute hoga, fir wapas aa ke "After next middleware" print hoga.

- **Run** → Runs the last middleware and prevents any more actions.

**Run ka Khulasa:**

- Ye **terminal middleware** hota hai
- Matlab: Jab ye middleware chalta hai, toh pipeline yahin pe ruk jaata hai
- Iske baad koi aur middleware execute nahi hota

**Code Explanation:**

app.Run(async context => {
await context.Response.WriteAsync("This is the end of pipeline");
});

**code ka khulasa:**

Jab ye chalta hai, toh response bhej diya aur pipeline khatam. Aage ke middleware ko call nahi karta.

- **Map** → Creates a separate branch of middleware for specific routes.

Map ka Khulasa:

- Specific route ya path ke liye middleware ka **branch** banata hai
- Matlab, agar request particular route match karti hai, toh us branch ke middleware execute honge
- Baaki requests ko alag middleware handle karte hain

app.Map("/admin", adminApp => {
adminApp.Run(async context => {
await context.Response.WriteAsync("Admin area");
});
});

app.Run(async context => {
await context.Response.WriteAsync("Public area");
});

code ka khulasa:

- Agar request `/admin` pe aayi, toh "Admin area" wali middleware chalegi
- Baaki routes pe "Public area" wali middleware chalegi
- **Filter** → Runs before/after controller action
- Middleware = Global level
- Filter = Controller/Action level

| Method | Pipeline Behavior | Example Use Case |
| --- | --- | --- |
| **Use** | Middleware added; calls next middleware | Logging, modifying request/response |
| **Run** | Terminal middleware; stops pipeline | Final response, short-circuit logic |
| **Map** | Branch pipeline for specific routes | Area-specific middleware (e.g., admin routes) |

🔹 **Filters**

Filters are used to run custom logic during the request pipeline, either before or after a controller or action executes.
Types: Authorization, Action, Result, Exception.

🔹 **ActionResult**

Return type → decides response to client.

✅ Types → View, JSON, XML, Files

🔹 **Razor View**

- Write **C# code inside HTML** (dynamic pages)
- **Razor Code** → @ syntax for inline C#

🔹 **View Files**

- **_ViewStart.cshtml** → Default layout for views
- **_Layout.cshtml** → Common structure (header, footer, nav)
- **@RenderBody** → Insert child view content in layout
- **@RenderPage** → Include another view content in page
- **PartialView** → Reusable view

🔹 **Routing Types**

- Convention-based
- Attribute-based

🔹 **Pass Data from Controller → View**

- **ViewBag** → Dynamic object (same request) 👉 ViewBag.Name = "Kasim"
- **ViewData** → Dictionary object (same request) 👉 ViewData["Name"] = "Kasim"
- **TempData** → Stores data temporary (across requests/redirects) 👉 TempData["Name"] = "Kasim"
- **Json** → through AJAX

🔹 **Redis**

Redis is used as an in-memory cache to reduce database calls. On the first request, data comes from the database and is stored in Redis with an expiry time (TTL). Next time, the same data is served directly from Redis, which is much faster. Once the cache expires, it fetches again from the database and refreshes Redis.

🔹 **Session Management**

- Stores **temporary, user-specific data** on server
- Configure in Program.cs → enable middleware → access via HttpContext.Session
- Uses → Login info, shopping carts, multi-page forms

**Where session stored?**

- Default = Server memory
- Also possible → SQL Server, Redis, Distributed cache

🔹 **Comparison of Triggers and Middleware**:

| Feature | **Triggers** | **Middleware** |
| --- | --- | --- |
| **Definition** | Automatically executed after a certain DB event (insert, update, delete). | Runs during the request-response cycle in a web app or API. |
| **Scope** | Database-specific, executes on certain DB events. | Application-specific, handles HTTP requests/responses. |
| **Execution** | Executes automatically after data modification. | Executes as part of the request processing chain. |
| **Use cases** | Logging changes, enforcing business rules, auditing data. | Authentication, authorization, logging, request validation. |
| **Impact on Flow** | Affects the database operations. | Affects the application's request/response flow. |
| **Error Handling** | Can raise errors that stop further execution in DB. | Can catch errors and send custom responses. |
| **Performance** | Can impact DB performance, especially with large data. | Can impact web app performance, especially with heavy computations in middleware. |
| **Execution Context** | Directly tied to DB operations. | Tied to the HTTP request lifecycle in the web server. |

### Conclusion:

**Triggers** and **middleware** both serve a similar purpose in terms of **executing custom logic**, but they operate in different layers of your system (DB vs Application) and at different times in the lifecycle of data processing (DB operations vs HTTP requests). **Triggers** are ideal for database-side operations like enforcing rules, logging, or cascading changes, while **middleware** is better suited for tasks like request validation, logging, authentication, etc., in the application layer.

- -------------------------------------------------------------------

🛡️ JWT Token & Security

- -------------------------------------------------------------------

### 🔸 How Token-Based Authentication Works

1. Client sends credentials to the server.
2. Server responds with a token.
3. Later, only the token is needed to access the resource.

### 🔸 Why is it called JWT token?

1. JSON stands for JavaScript object notation.
2. JSON is a data format with name and value. Because we receive the token in JSON format so it’s termed as JWT Token.

### 🔸 What are Identity and claims?

Identity Identify user, Claims talk about roles.

### 🔸 Authentication vs Authorization

- **Authentication** → Confirms user identity (WHO the user is).
- **Authorization** → Defines roles/rights (WHAT the user can do).

### 🔸 Claims vs Roles

- **Roles** → Classify user types (Admin, User, etc.)
- **Claims** → Contain details like Browser=Chrome, SeniorCitizen=true.
    - Claims can have roles but not all claims are roles.
- **Roles** assigned to user type.
- **Claims** assigned to user.

### 🔸 Principal vs Identity

- **Identity** → User + Roles + Claims
- **Principal** → Encapsulates Identity, used in thread/context.

### ⚠️ Can We Store Critical Info in JWT?

> ❌ No. It's only Base64 encoded, easy to decode.
> 

### 🔸 3 Sections of JWT Token

1. **Header** – Algorithm & Token type
2. **Payload** – Identity & Claims info
3. **Signature** – Created using Header + Payload + Secret key

![image.png](attachment:d4c811ce-bec8-4d7b-9599-572de37a8bae:image.png)

### 🔸 Steps to Create JWT Token in MVC

1. Install **`Microsoft.AspNetCore.Authentication.JwtBearer`**.
2. Choose algorithm (e.g., **HMACSHA256**) {HEADER}
3. Create claims {PAYLOAD}
4. Generate token using algorithm + claims + secret {SIGNATURE}

![image.png](attachment:4775e03f-ad40-42d9-8ebd-d535627ca141:image.png)

🔸 **Where is Token Checked in [ASP.NET](http://asp.net/) MVC ?**
Token authenticity is checked in the pipeline. In the startup we need to add this “JwtBearer” check in the pipeline.

![image.png](attachment:df7d21e0-8b4d-465c-a4c9-6ef3e92bdfce:image.png)

Below is how to add the same in pipeline.

![image.png](attachment:57896bdb-4f85-4fef-8b69-865a94fbbd87:image.png)

![image.png](attachment:cf2832ca-895d-41e5-ba90-28859eb481ec:image.png)

You also need to call “UseAuthentication” and “UseAthorization” in same sequence first Authentication and then Authorization as shown in the below code.

app.UseAuthentication();
app.UseAuthorization();
🔸 Authorize Attribute

Apply JWT protection on specific controllers:

```csharp
[Authorize]
public class ValuesController : ControllerBase {}

```

### 🔸 Step to Implement JWT Token Security

1. Import JWT package.
2. Create token (Header, Payload, Signature).
3. Add Bearer check in pipeline.
4. Use `[Authorize]` on protected controllers.

### 🔸 HTTP Status Code

- **200**OK
- 201New Resource Created
- 204No Content(The server Processed the request successfully) and it is not returning any content.
- 301Moved Permanently
- 302Moved temporarily
- 400Bad Request
- 401Unauthorised
- 404NOT FOUND
- 405Method Not Allowed
- 500Internal server error
- 503Service Unavailable(ex- down for Maintenance

### 🔸 Sending Token from Client Side

**Standard header format:**

```
Authorization: Bearer <token>

```

- **Fetch API:**

```jsx
fetch('url', {
 method: 'GET',
 headers: { 'Authorization': 'Bearer <token>' }
});

```

- **jQuery:**

```jsx
$.ajax({
 url: 'url',
 type: 'GET',
 headers: { 'Authorization': 'Bearer <token>' }
});

```

- **Angular:**

```tsx
var headers = new HttpHeaders();
headers = headers.append("Authorization", "Bearer " + token);
this.http.post('url', {}, { headers: headers }).subscribe();

```

**🔸 Increase UX experience in Mobile apps to avoid relogin ?**
Use a refresh token.

🔸 **What is a refresh tokens?**

Refresh token is a separate token by which you can get a new JWT token.

### 🔸 Access vs Refresh Tokens

| Access Token | Refresh Token |
| --- | --- |
| Used to access resources | Used to get new Access Token |
| Short expiry time | Longer expiry time |

### 🔸 How Refresh Token Works

1. Credentials sent → Access + Refresh token generated
2. Access resource with Access token
3. Token expires
4. Use Refresh token to get a new Access token

⏳ Refresh token expiry > Access token expiry

![image.png](attachment:4b342628-e86f-4020-9da0-b2c5a89f94e8:image.png)

🔸**Refresh tokens last longer than access tokens?**
Access tokens expire quickly, so if someone steals one, they only have a short time to misuse it. This helps keep things more secure.

🔸**Explain revocation of Refresh token?**
Revocation of Refresh token means expiring / invalidating the token for creating any more JWT token. User needs to freshly authenticate to get new Refresh token.
**🔸How to extract Principal from a Token?**
You can extract “Principal(identity (user info) inside the token)” and “Token” by using “TokenHandler” class.

![image.png](attachment:1d175989-0731-4f45-8de2-fcba5360fd1e:image.png)

🔸**What is the best practice to store tokens at client side?**

In-memory:- Using the application variable we can store the token when the application is running.
Cookie :- If you still want to store cookie is a good place.
IndexedDB, Session storage and local storage are prone to XSS attacks.

**🔸If we store JWT in cookie how to save from XX attacks?**

Create cookie using HTTP only. By doing so this cookie can not be read using JavaScript “document.cookie”. In other words cookie is safe from XSS attacks.

🔸**OAUTH vs OpenID vs OpenIdConnect vs JWTToken?**
OpenId,OAuth and OpenIdConnect are protocols while JWTToken is just a token.
1. OpenId is all about authentication.
2. OAUTH is all about authorization.
3. OpenId connect has both of them.
🔸**When should we use what?**
• OpenId ( Who ?): - You want to just know if the user exists in the system in or not. Like shopping sites , mobile applications , single sign on etc.
• OAUTH (What ?) : - When third party application tries to access resources.
• OpenIDConnect: - When you want to authenticate and authorize as well like intranet websites.

🔸**What is Identity Server?**
Identity server is a free opensource server which helps to implement openId connect and OAuth.

🔸**How to implement Single Sign on?**
For single sign on the authentication / authorization server should be separate. The websites who want to belong to a common federation gets in to trust with this centralized Authentication / Authorization server.
Many developers use IdentityServer for single sign on.

### 🔸 Scope in Identity Server

- **Scope = Roles / Permissions**
- --------------------------------------------------------------------------

**C# LOGICAL Q&A**

- --------------------------------------------------------------------------

//Even Odd
int No = 3;
Console.WriteLine(No % 2 == 0 ? "Even: " + No : "Odd: " + No);

//Factorial
int no = 5; int Fact = 1;
for (int i = 1; i <=no; i++)
{
Fact =* i;
}
Console.WriteLine("Factorial: " + Fact);

//REVERSE STRING
string name = "Kasim";
int len = name.Length;
string rev = "";
for (int i = len - 1; i >= 0; i--)
rev = rev + name[i];
Console.WriteLine(rev);
Console.ReadLine();

//Reverse Number
int number = 5432;
int rem, ReverseNumber = 0;
while (number != 0)
{
rem = number%10;//5432%10=2
ReverseNumber = ReverseNumber * 10 + rem;//0*10+2=20
number = number/10;//whenever I want to remove last number
//then I'll devide number/10.
}
Console.WriteLine("ReverseNumber: " + ReverseNumber);
Console.ReadLine();

//Palindron
int number = 123, originalNumber = number, rev = 0;
while (number > 0)
{
rev = rev * 10 + number % 10;
number /= 10;
}
Console.WriteLine(originalNumber == rev ? "Palindrome: " + rev : "Not a Palindrome: " + rev);

//Fibo
int previous = 0, last = 1, sum;
for (int i = 1; i <= 10; i++)
{
sum = previous + last;//0+1=1; 1+1=2; 1+2=3; 2+3=5;...
Console.WriteLine("Sum:" + sum);//1; 2; 3; 5;...
previous = last;//1; 1; 2;...
last = sum;//1; 2; 3;...
}

//Armstrong Number

> e.g. 153 → 1³ + 5³ + 3³ = 153
> 

```csharp
int num = 153, temp = num, result = 0;
while (temp != 0)
{
    int digit = temp % 10;
    result += digit * digit * digit;
    temp /= 10;
}
Console.WriteLine(result == num ? "Armstrong Number" : "Not an Armstrong Number");

```

### **Prime Number Check**

```csharp
int number = 29;
bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(number); i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}
Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");

```

### **Swap Two Numbers (Without Temp Variable)**

```csharp
int a = 10, b = 20;
a = a + b; // a = 30
b = a - b; // b = 10
a = a - b; // a = 20
Console.WriteLine($"a: {a}, b: {b}");

```

### **Check Vowel or Consonant**

```csharp
char ch = 'e';
ch = Char.ToLower(ch);
if ("aeiou".Contains(ch))
    Console.WriteLine("Vowel");
else
    Console.WriteLine("Consonant");

```

### **Leap Year Check**

```csharp
int year = 2024;
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    Console.WriteLine("Leap Year");
else
    Console.WriteLine("Not a Leap Year");

```

// Pattern: Increasing Stars
// *
// **
// ***
// ****
for (int i = 1; i <= 4; i++)
{
for (int j = 1; j <= i; j++)
{
Console.Write("*");
}
Console.WriteLine();
}

// Pattern: Decreasing Stars
// ****
// ***
// **
// *
for (int i = 1; i <= 4; i++)
{
for (int j = 4; j >= i; j--)
{
Console.Write("*");
}
Console.WriteLine();
}

// Pattern: Right-aligned Increasing
//    *
//   **
//  ***
// ****
for (int i = 1; i <= 4; i++)
{
for (int j = 3; j >= i; j--)
{
Console.Write(" ");
}
for (int k = 1; k <= i; k++)
{
Console.Write("*");
}
Console.WriteLine();
}

// Pattern: Right-aligned Decreasing
// ****
//  ***
//   **
//    *
for (int i = 1; i <= 4; i++)
{
for (int k = 2; k <= i; k++)
{
Console.Write(" ");
}
for (int j = 4; j >= i; j--)
{
Console.Write("*");
}
Console.WriteLine();
}

// Pattern: Diamond Half
//   *
//  **
// ***
//****
// ***
//  **
//   *
for (int i = 1; i <= 4; i++)
{
for (int j = 3; j >= i; j--)
{
Console.Write(" ");
}
for (int k = 1; k <= i; k++)
{
Console.Write("*");
}
Console.WriteLine();
}
for (int i = 1; i <= 3; i++)
{
for (int j = 1; j <= i; j++)
{
Console.Write(" ");
}
for (int k = 3; k >= i; k--)
{
Console.Write("*");
}
Console.WriteLine();
}

// Pyramid Pattern
//     *
//    * *
//   * * *
//  * * * *
for (int i = 1; i <= 4; i++)
{
for (int j = 4; j >= i; j--)
{
Console.Write(" ");
}
for (int k = 1; k <= i; k++)
{
Console.Write(" *");
}
Console.WriteLine();
}

- -------------------------------------------------------------------

SQL

- -------------------------------------------------------------------
- DISTINCT
- >The SELECT DISTINCT statement is used to return only distinct (different) values.
- Order By
- >The ORDER BY keyword is used to sort the result-set in ascending or descending order.
- AND
- >The AND operator is used to filter records based on more than one condition, like if you want to return all customers from Spain that starts with the letter 'G'.
- Not
- >
NOT operators are used to reverse the result of a condition.
WHERE CustomerName NOT LIKE 'A%'
WHERE CustomerID NOT BETWEEN 10 AND 60
WHERE City NOT IN ('Paris', 'London')
WHERE NOT CustomerID > 50
WHERE NOT CustomerID < 50
- ISNULL
- >The SQL Server ISNULL() function lets you return an alternative value when an expression is NULL.
- INSERT INTO
- >The INSERT INTO statement is used to insert new records in a table.
- EXISTS
- >The EXISTS operator is used to test for the existence of any record in a subquery. The EXISTS operator returns TRUE if the subquery returns one or more records.
- COALESCE
- >That returns the first non-NULL value from a list.
The first non-NULL value means the first value in a list of arguments that is not NULL.
Eg:

SELECT COALESCE(NULL, NULL, 'Apple', 'Banana');
This query returns 'Apple' because it is the first value in the list that is not NULL.

SELECT ID, COALESCE(Value1, Value2, Value3) AS FirstNonNullValue
FROM SampleTable;

- IS NOT NULL
- >The IS NOT NULL operator is used to test for non-empty values (NOT NULL values).
- UPDATE
- >The UPDATE statement is used to modify the existing records in a table.
- DELETE
- >The DELETE statement is used to delete existing records in a table.
- SELECT TOP
- >The SELECT TOP clause is used to specify the number of records to return.
- OR
- >The OR operator is used to filter records based on more than one condition, like if you want to return all customers from Germany but also those from Spain
- Differentiate between a HAVING CLAUSE and a WHERE CLAUSE.
- >use WHERE to filter rows use HAVING to filter groups.
- Transactions.
- >Transactions are a set of steps done together as one task.
- SAVEPOINT
- >SAVEPOINT in SQL is an intermediate checkpoint within a transaction to which you can roll back without affecting the entire transaction.
- What are COMMIT and ROLLBACK in SQL

COMMIT ends the current transaction, making its changes permanent, while ROLLBACK undoes the transaction.

- Differentiate between a primary key and a unique key
- >Primary key doesn't allow NULLs, but unique key allows one NULL.
- >By default, clustered index on the column are created by the primary key whereas nonclustered index are created by unique key.
- Differentiate between DELETE and TRUNCATE.
- Truncate can not be **rolled back** while Delete can be.
- Truncate **locks** the whole table, while Delete locks each row.
- Truncate resets the **Identity column** counter, but Delete doesn't
- Truncate doesn't activate **triggers**, but Delete does.
- What is difference between clustered and non clustered index?
- >A table can have only **one Clustered Index** at a time which is created on primary key and can have more than one non clustered indexes (maximum up to 999)
- >Non* clustered index is faster than clustered index because when we use DML statement on clustered index, performance issues may occurred since it has to update the index every time a DML statement is executed.
- Difference between ROW_NUMBER, ROW function?

ROW_NUMBER: assigns a unique number to each row.

RANK: can assign the same rank to rows with identical values in the ordering column(s).

ROW_NUMBER: has no gaps; it always increments by 1.

RANK: leaves gaps when there are ties.

- What is Trigger?

A trigger in SQL is a set of instructions that automatically runs when certain changes (like insert, update, or delete) happen to a table.

- What are cursors and when they are useful?

Cursors in SQL let you go through each row of a result set one at a time.

They're handy when you need to work with data row by row, especially for tasks like complex calculations or updates that need individual attention for each row.

- What are Magic tables in SQL Server?

Magic tables in SQL Server are special **virtual tables**, not physical ones, known as "Inserted" and "Deleted."

They're used with triggers to access rows that have been inserted, deleted, or updated.

- What is difference between stored procedure and user defined function?

Stored procedures can change table data, but user-defined functions cannot.

- What is a Linked Server?

A Linked Server is a way to connect and query a remote database server from a local one, allowing them to work together in a single group.

- What is a WITH(NOLOCK)?

WITH(NOLOCK) is used to unlock the data which is locked by the transaction that is not yet committed. This command is used before SELECT statement.

- UNION & UNION ALL

The UNION and UNION ALL operators are used to combine the result sets of two or more SELECT statements.

- Difference UNION & UNION ALL

UNION: Removes duplicate records

UNION ALL: Not removes duplicate records

- What is an Index?

An index is performance tuning method of allowing faster retrieval of records from the table. An index creates an entry for each value and it will be faster to retrieve data.

- What are all the different types of indexes?

Unique Index.

This indexing does not allow the field to have duplicate values if the column is unique indexed. Unique index can be applied automatically when primary key is defined.

Clustered Index.

This type of index reorders the physical order of the table and search based on the key values. Each table can have only one clustered index.

NonClustered Index.

NonClustered Index does not alter the physical order of the table and maintains logical order of data. Each table can have 999 nonclustered indexes.

- What is subquery?

A subquery is a query within another query. The outer query is called as main query, and inner query is called subquery. SubQuery is always executed first, and the result of subquery is passed on to the main query.

- What is a constraint?

Constraint can be used to specify the limit on the data type of table. Constraint can be specified while creating or altering the table statement. Sample of constraint are.

NOT NULL

CHECK

DEFAULT

UNIQUE

PRIMARY KEY

FOREIGN KEY

- Difference between PRIMARY KEY/FOREIGN KEY
- >A primary key uniquely identifies each record in a table, while a foreign key links records between two tables.
- What is data Integrity?

Data integrity means making sure the data in a database is accurate and consistent. It's like making sure that the information in your database is reliable and correct.

- What is Auto Increment?

Auto Increment is like a self-increasing counter that assigns a unique number to each new row added to a table.

What is the difference between Cluster and Non Cluster Index?

Clustered index: Reorganizes rows in the table for fast access but changes their physical order.

Non-clustered index: Creates a separate list for quick access without rearranging the rows.

What is Self Join?

A self-join compares values within the same table, using aliases to distinguish between them.

What is Cross Join?

Cross join combines each row from one table with every row from another table, resulting in a Cartesian product.

- What are aggregate and scalar functions?

Aggregate functions are used to evaluate mathematical calculation and return single values. This can be calculated from the columns in a table.

Scalar functions return a single value based on the input value.

Example * .

Aggregate – max(), count – Calculated with respect to numeric.

Scalar – UCASE(), NOW() – Calculated with respect to strings.

- How can you create an empty table from an existing table?

Select * into studentcopy from student where 1=2

- Difference between SELECT INTO, INSERT INTO

The main difference is that "SELECT INTO" creates a new table based on the result set of a query, copying both data and structure, while "INSERT INTO" inserts data into an existing table.

- - SELECT INTO creates a new table based on the result set of a query

SELECT * INTO NewTable FROM ExistingTable WHERE Condition = 'Value';

- - INSERT INTO inserts data into an existing table

INSERT INTO ExistingTable (Column1, Column2) VALUES ('Value1', 'Value2');

- Explain query execution plan?

1 The optimizer available in SQL Server optimizes the code to be effectively executed.

2 A query execution plan shows how this optimizer would run the query.

3 Query execution plan can be viewed by :

4 Using the Show Execution Plan option available in Query Analyzer,

5 Displaying Estimated Execution Plan on the query dropdown menu,

6 Use the SET SHOWPLAN_TEXT ON command before running a query and capturing the execution plan event in a SQL Server Profiler trace.

- What is recursion? Is it possible for a stored procedure to call itself or recursive stored procedure? How many levels of SP nesting is possible?

Recursion is when a stored procedure calls itself. Yes, it's possible for a stored procedure to call itself. The number of levels of nesting is determined by the setting 'sp_configure' 'nested triggers'.

Stored procedures and managed code references can be nested up to 32 levels.

- Differentiate between a Local and a Global temporary table?
- A local temporary table exists only for the duration of a connection or, if defined inside a compound statement, for the duration of the compound statement.
- Global temporary tables (created with a double “##”) are visible to all sessions.
- Global temporary tables are dropped when the session that created it ends, and all other sessions have stopped referencing it.
- Views-
- >A view is a virtual table made from the result of a SELECT query.
- WITH CHECK OPTION-
- >in views ensures changes made through the view meet its conditions.
- Data Integrity -
- >Makes sure data is right and stays that way.
- Create Empty Table-
- >SELECT INTO to create a new table, it copies the structure (columns and their data types) from the source table, but it does not copy any constraints, indexes, triggers, or schemas associated with the source table.
- Create Empty Table-
- >SELECT INTO to create a new table, it copies the structure (columns and their data types) from the source table, but it does not copy any constraints, indexes, triggers, or schemas associated with the source table.
- INSERT INT-
- >simply adding new rows of data into an existing table. It does not create a new table. Therefore, the INSERT INTO statement does not copy any table structure, constraints, indexes, triggers, or schemas.
- What is CTE (Common Table Expression)?
- CTE (Common Table Expression) is a temporary result set that you can reference within a SELECT, INSERT, UPDATE, or DELETE statement.
- Temporary Tables-
- >Provide temporary storage for session-specific or global data without permanently altering the database schema.
- Temporary Variables-
- >Variables defined using **DECLARE** for temporary data storage within a session.
- What is Scheduled job and how to create it?
1. Connect to your database of SQL server in SQL Server Management Studio.
2. On the SQL Server Agent. There you will find a Jobs folder. Right click on jobs and choose Add New.
3. A New Job window will appear. Give a related name for the job.
4. Click next on the "Steps" in the left menu. A SQL job can have multiple steps either in the form of SQL statement or a stored procedure call.
5. Click on the "Schedules" in the left menu. A SQL job can contain one or more schedules. A schedule is basically the time at which sql job will run itself. You can specify recurring schedules also.
- Using scheduled job you can also create alert and notifications.
- What is SQL Profiler?

SQL Server provides a graphical tool which helps system administrators to monitor T* SQL statements of Database Engine.

- What is REPLACE and STUFF function in SQL Server?

STUFF: This function is used to replace the **part of string** with some another string.

REPLACE: This function is used to replace **all the occurrences of particular string** by another string.

- MIN() and MAX()
- >The MIN() function returns the smallest value of the selected column.
- >The MAX() function returns the largest value of the selected column.
- COUNT()
- >The COUNT() function returns the number of rows that matches a specified criterion.
- SUM()
- >The SUM() function returns the total sum of a numeric column.
- AVG()
- >The AVG() function returns the average value of a numeric column.
- LIKE
- >The LIKE operator is used in a WHERE clause to search for a specified pattern in a column.
- Wildcard
- >Wildcard characters are used with the LIKE operator. The LIKE operator is used in a WHERE clause to search for a specified pattern in a column.
- IN
- >The IN operator allows you to specify multiple values in a WHERE clause. The IN operator is a shorthand for multiple OR conditions.
- BETWEEN
- >The BETWEEN operator selects values within a given range. The values can be numbers, text, or dates.
- >The BETWEEN operator is inclusive: begin and end values are included.
- JOINS
INNER
LEFT
RIGHT
FULL OUTER
- Self join
- >A self join is a regular join, but the table is joined with itself.
- GROUP BY
- >The GROUP BY statement group rows that have the same values into summary rows, like "find the number of customers in each country".
- ANY,ALL
- >The ANY and ALL operators allow you to perform a comparison between a single column value and a range of other values.
- SELECT INTO
- >The SELECT INTO statement copies data from one table into a new table.
- INSERT INTO SELECT
- >The INSERT INTO SELECT statement copies data from one table and inserts it into another table.
- >The INSERT INTO SELECT statement requires that the data types in source and target tables match.
- Collation:
- >Using collation, we can set specific rules for how text data is sorted and compared.
- Error Handling-
- Using **TRY...CATCH** to handle errors in SQL scripts.
- **Example:** Catching errors in a transaction to rollback if needed.
- **Example:** BEGIN TRY ... END TRY BEGIN CATCH ... END CATCH;
- Auto Increment- IDENTITY(1,1)
- Self-Join- Joins a table to itself.
- What is collation?

Collation sets rules for sorting and comparing text, handling different languages and character sizes using ASCII values.

- query execution plan:
- >A query execution plan is like a map that shows how the database will find and fetch the data you want when you run a query.
- Scheduled job:
- >A scheduled job is a task programmed to run automatically at specific times, like a reminder. You can create one by telling the computer what task to do and when to do it.
- What is Online Transaction Processing (OLTP)?
- Online Transaction Processing or OLTP manages transaction based applications which can be used for data entry and easy retrieval processing of data. This processing makes like easier on simplicity and efficiency. It is faster, more accurate results and expenses with respect to OTLP.
- Example – Bank Transactions on a daily basis.

Jaise ek baar ek project me ek report query bahut slow thi, toh humne execution plan check karke dekha ke full table scan ho raha tha. Humne proper index banaya aur query ko rewrite kiya, jisse memory usage aur execution time dono 70% tak reduce ho gaya.

![image.png](attachment:6bb67361-bdb8-4d0f-b530-1f2e0fd69acb:image.png)

- ---------------------------------------------------------------------------------------------

Angular

- ---------------------------------------------------------------------------------------------

✅ Angular Interview Notes

➤ Introduction

- Angular is a JavaScript framework to build dynamic web apps.
- Helps bind UI with JS model using binding techniques.
- Used to build SPA (Single Page Applications).
- Features: DI, HttpClient, Input/Output, Lazy Loading, Routing, Services.

➤ Basic Building Blocks

1. Template – The HTML view.
2. Component – Binds UI to data model.
3. Modules – Group of components, pipes, services.
4. Bindings – Communication between component and template.
5. Directive – Modify DOM behavior.
6. Services – Reusable business logic.
7. DI (Dependency Injection) – Injects instances of classes where needed.

➤ Bindings

- Interpolation – {{ value }}
- Property Binding – [src]="imageUrl"
- Event Binding – (click)="doSomething()"
- Two-way Binding – [(ngModel)]="value"
- Attribute Binding – In some cases where property bindings not work we 
switch to **attribute binding.**

### 🔹 Common cases where Attribute Binding is needed:

1. **Table attributes**
    - `colspan`, `rowspan`
        
        Example:
        
    
    ```html
    <td [attr.colspan]="cols">Data</td>
    ```
    
2. **Accessibility attributes (ARIA)**
    - `aria-label`, `aria-hidden`, `aria-expanded`, etc.
        
        Example:
        
    
    ```html
    <button [attr.aria-label]="btnLabel">Click</button>
    ```
    
3. **Custom data attributes** (`data-*`)
    - For passing custom values to elements.
        
        Example:
        
    
    ```html
    <div [attr.data-user-id]="user.id"></div>
    ```
    
4. **Other special attributes not mapped to properties**
    - `for` (in `<label>`)
    - `readonly` (sometimes)
    - `custom attributes` used in third-party libraries

➤ Directives

Directives help attach behavior to HTML DOM elements.

Types:

- Structural – Changes DOM layout. (*ngIf, *ngFor, *ngSwitch)
- Attribute – Changes DOM appearance. (ngClass, ngStyle, [style.color], [class.active], [hidden], [src])

➤ Decorator

Decorators are special functions that modify or enhance classes or functions (e.g., @Component, @NgModule, @Injectable, @Directive, @Input, @Output, @HostListener, @Pipe)

➤ SPA (Single Page Application)

- Loads main UI once.
- Subsequent navigation happens without full page reload.

➤ Routing

- Defines navigation in app using RouterModule.
- Routes map path to components.

const routes = [

{ path: 'home', component: HomeComponent }

];

- router-outlet – Placeholder where routed views are loaded.

➤ Lazy Loading

- Modules loaded on-demand for better performance.

Steps:

1. Create feature modules.
2. Add separate routing for them.
3. Use loadChildren in main routing.
4. Use forRoot in main module and forChild in feature modules.

➤ Content Projection

- Pass content from parent to child using <ng-content>.

➤ Lifecycle Hooks

1. constructor – Class instantiation
2. ngOnChanges – Fires when an **input property changes**.
3. ngOnInit – Fires when the **component is displayed** for the first time.
4. ngDoCheck – Runs every time Angular **checks if something has changed** in the component.
5. ngAfterContentInit – ngAfterContentInit is called after **Angular puts the parent’s content inside the child** component using <ng-content>.
6. ngAfterViewInit – Fires After view & child **views initializes**
7. ngAfterViewChecked – Runs every time Angular **looks for changes in the component’s** template and its child components.
8. ngOnDestroy – Cleanup before Angular destroys the component.

➤ Short Explanation of Life Cycle hook:

constructor – class created

ngOnChanges – input property changed

ngOnInit – component **displayed** first time

ngDoCheck – Angular **checks** for changes

ngAfterContentInit – parent’s content **inserted** via <ng-content>

ngAfterViewInit – component view & child views **initialized**

ngAfterViewChecked – runs on every **check** of component & child views

ngOnDestroy – cleanup before destruction

➤ Constructor vs ngOnInit()

Constructor                 ngOnInit

TS feature                 Angular hookpppm

No binding yet         Binding done

DOM not ready        DOM accessible

Use for DI setup       Use for init logic

➤ HTTP Calls in Angular

Steps:

1. Import HttpClientModule.
2. Inject HttpClient.
3. Use get, post, etc.
4. Use subscribe() to consume.

➤ Http Interceptors

- Add auth token
- Centralized error handling
- Modify requests/responses
- Retry failed calls using RxJs

➤ ViewChild vs ContentChild

Type                                                 Accesses

ViewChild, ViewChildren               Elements from own template

ContentChild, ContentChildren     Elements inserted from parent

➤ Data Sharing Between Components

| Method | Direction | Use-case |
| --- | --- | --- |
| `@Input()` | Parent → Child | Pass data down |
| `@Output()` + `EventEmitter` | Child → Parent | Emit events |
| Services | Any ↔ Any | Shared logic/data |
| Routing (params, queryParams, state) | Route ↔ Component | Transfer via navigation |
| `@ViewChild()` | Parent → Child | Access child methods |
| `@ContentChild()` | Parent → Child | Access projected content |
| BehaviorSubject | Global ↔ Any | Reactive shared state |
| NgRx / NGXS | Global | Large apps state mgmt |
| Local Reference | Template ↔ Component | Direct access |
| `postMessage` / `localStorage` | App ↔ External | Cross-tab or persistent data |

➤ Pipes

Used to transform data in templates.

Examples:

- uppercase, lowercase, date, currency
- async – For observables
- json, percent, titlecase, slice, i18nPlural, i18nSelect

Custom Pipe Example:

@Pipe({ name: 'square' })

export class SquarePipe implements PipeTransform {

transform(value: number): number {

return value * value;

}

}

➤ RxJs (Reactive Extensions)

Stream: Data emitted from observables.

RxJs needs: To handle asynchronous data stream.

- Observables: Represent async data stream.
- Observer: Subscribes to observable to receive the stream.
- Subscription: “Subscribe” function starts the stream from observable to the observer function.

const sub = obs.subscribe(data => ...);

sub.unsubscribe();

➤ RxJs Operators

- map, filter, merge, concat, from
- debounceTime, distinctUntilChanged, pluck, delay

➤ RxJs vs Promises

RxJs                              Promise

Streams                   One value

Cancelable              Not cancelable

Operators               No operators

Multiple emits        One emit only

➤ Change Detection Strategy

- Angular checks changes in data and updates view.
- Default: Full tree detection.
- OnPush: Detects only on input change/event.
- Use OnPush for performance optimization.

➤ *TrackBy in ngFor

- Used to optimize rendering.
- ngFor="let item of list; trackBy: trackByFn"

➤ Standalone Components (Angular 14+)

- Components without a module.

@Component({

standalone: true,

...

})

➤ Route Guards

- Control navigation.

| **Guard** | **Purpose** | **Example Scenario** |
| --- | --- | --- |
| **CanActivate** | Allow or deny access | Prevent users from accessing `/admin` if they are not logged in or not an admin. |
| **CanDeactivate** | Prevent leaving the page | Ask for confirmation if a user tries to leave a form page with **unsaved changes**. |
| **Resolve** | Pre-fetch data before loading | Load user profile data before displaying the **User Detail** page. |
| **CanLoad** | Prevents loading the module itself (code won’t even be downloaded). | Block lazy-loaded `AdminModule` if the user lacks permissions (e.g., not authorized). |

**➤ Template vs Reactive Forms**

| **🔹 Feature** | **🟢 Template-driven** | **🔵 Reactive** |
| --- | --- | --- |
| **Approach** | UI-based
  (HTML-first) | Code-based
  (TS-first) |
| **Form Controls** | Uses
  ngModel | Uses
  FormControl, FormGroup, FormBuilder |
| **Suitable For** | Simple forms | Complex &
  large forms |
| **Validation** | Inline via HTML
  attributes | In component via
  TS |
| **Form Structure** | Defined in
  template | Defined in
  component |
| **Scalability** | Hard to scale for
  large forms | Better for large
  and dynamic forms |
| **Testing** | Difficult to unit
  test | Easy to write unit
  tests |
| **Control over data** | Less programmatic
  control | Full programmatic
  control |
| **Two-way binding** | Uses
  [(ngModel)] | One-way via
  FormControl |
| **Performance** | Slightly slower in
  complex cases
 | More optimized |

➤ Dynamic Component Loading

- Load components at runtime using ViewContainerRef, ComponentFactoryResolver.

➤ State Management

- For sharing state globally.
- Options:

○ BehaviorSubject in service

○ NgRx (Redux pattern)

➤ Subject vs BehaviorSubject vs ReplaySubject

Type                           Behavior

Subject                   Emits after subscribe

BehaviorSubject     Emits latest value immediately

ReplaySubject        Emits last N values

➤ Zone.js

- Angular uses it to track async events (like setTimeout, HTTP).
- Automatically triggers change detection after async events.

➤ Optimization Techniques

- OnPush strategy
- trackBy in *ngFor
- Lazy loading
- Preloading strategies
- ng build --prod (tree shaking)
- Avoid unnecessary bindings

➤ Internationalization (i18n)

- Support multiple languages using Angular's i18n tools.
- Use translation files (xlf, json) or pipes (i18nPlural, i18nSelect)

➤ Testing in Angular

- Tools: Jasmine + Karma
- TestBed – Testing environment
- spyOn – Mock functions
- fakeAsync, tick() – For async testing

➤ Animations

- Import @angular/animations
- Use trigger, state, transition, animate

trigger('toggle', [

state('open', style({ height: '100px' })),

transition('open <=> closed', animate('300ms'))

])

➤ Angular CLI Commands

- ng new – Create new project
- ng serve – Run app
- ng build --configuration production – Build for prod
- ng test – Run unit tests
- ng lint – Linting
- ng update, ng add – For libraries

➤ SSR (Server-Side Rendering)

- Use Angular Universal.
- Server renders the first page — improves SEO & speed.
- --------------------------------------------------------------------------

**API, Entity Framework & LINQ**

- --------------------------------------------------------------------------

**🔹 Web API**

**What is Web API?** → Framework to build HTTP
services for web, mobile, and desktop apps using RESTful principles.

**REST vs SOAP?** → REST uses HTTP verbs
(lightweight, JSON), SOAP uses XML protocols (heavy, enterprise).

**HTTP Verbs?** → GET (retrieve), POST (create),
PUT (update/replace), PATCH (partial update), DELETE (remove).

**What is RESTful API?** → API following REST
principles: stateless, cacheable, uniform interface, client-server
architecture.

**Status Codes?** → 2xx (success), 3xx (redirect),
4xx (client error), 5xx (server error). → 200 (OK), 201 (Created), 400 (Bad
Request), 401 (Unauthorized), 404 (Not Found), 500 (Internal Error).

**Content Negotiation?** → Client specifies
preferred response format via Accept header (application/json,
application/xml).

**Versioning Strategies?** → URL (/api/v1/), Query
(?version=1), Header (Accept-Version), Media Type versioning.

**API vs Web Service?** → Web Service uses
SOAP/XML, API is broader concept including REST/JSON.

**Difference between ApiController and Controller?**
→ ApiController: Auto model validation, no view support, JSON by default. →
Controller: Manual validation, supports views, flexible return types.

**What is Action Filter?** → Executes code
before/after action execution (authentication, logging, caching).

**Global Exception Handling?** → Use middleware or
IExceptionFilter to catch unhandled exceptions globally.

**Authentication vs Authorization?** →
Authentication (who you are), Authorization (what you can access).

**JWT Token?** → JSON Web Token: encoded user
claims, stateless, contains header.payload.signature.

**CORS (Cross-Origin Resource Sharing)?** → Browser
security feature allowing/blocking cross-domain requests, configured in
startup.

**Rate Limiting?** → Restrict number of API calls
per user/IP to prevent abuse and ensure fair usage.

**API Gateway?** → Single entry point managing
routing, authentication, rate limiting, and load balancing for microservices.

**Idempotent Methods?** → GET, PUT, DELETE produce
same result when called multiple times; POST is not idempotent.

**Swagger/OpenAPI?** → Documentation standard for
REST APIs, auto-generates interactive API documentation.

**Difference between Synchronous and Asynchronous API?**
→ Sync: Client waits for response, blocks thread. → Async: Client continues
processing, handles response later using async/await.

**🔹 Entity Framework (EF)**

**What is Entity Framework?** → ORM
(Object-Relational Mapping) framework that maps database tables to .NET
objects.

**Code First vs Database First vs Model First?** →
Code First: Classes → Database, Database First: Database → Classes, Model
First: Visual model → Database.

**DbContext vs DbSet?** → DbContext: Database
connection session, DbSet: Collection of entities (table representation).

**Lazy Loading vs Eager Loading vs Explicit Loading?**
→ Lazy: Load on access (.Navigation), Eager: Load with Include(), Explicit:
Manual Load().

**What is Migration?** → Version control for
database schema changes, tracks and applies database updates.

**Fluent API vs Data Annotations?** → Fluent API:
Configuration in OnModelCreating (flexible), Data Annotations: Attributes on
properties (simple).

**Change Tracking?** → EF monitors entity changes
(Added, Modified, Deleted) in DbContext for SaveChanges().

**AsNoTracking()?** → Disables change tracking for
read-only queries, improves performance for large datasets.

**First() vs FirstOrDefault() vs Single() vs
SingleOrDefault()?** → First: Exception if empty, FirstOrDefault: null if
empty, Single: Exception if 0 or >1, SingleOrDefault: null if 0, exception
if >1.

**IEnumerable vs IQueryable?** → IEnumerable:
In-memory LINQ (LINQ to Objects), IQueryable: Database queries (LINQ to SQL).

**N+1 Problem?** → One query + N additional queries
for related data; solve with Include() or projection.

**What is Unit of Work pattern?** → DbContext
implements Unit of Work, maintains list of objects and commits all changes in
single transaction.

**Repository Pattern?** → Abstraction layer between
data access and business logic, makes testing easier.

**Connection Pooling?** → EF reuses database
connections to improve performance and resource utilization.

**EF Core vs EF 6?** → EF Core: Cross-platform,
lightweight, better performance; EF 6: Windows only, more features.

**Global Query Filters?** → Automatically apply
WHERE clause to all queries for an entity (soft delete, multi-tenancy).

**Shadow Properties?** → Properties not in entity
class but configured in EF model (audit fields, foreign keys).

**Owned Entity Types?** → Value objects that don't
have identity, stored in same table as owner entity.

**Split Queries?** → Break complex queries with
multiple includes into separate database queries using AsSplitQuery().

**Bulk Operations?** → EF Core 7+ supports
ExecuteUpdate() and ExecuteDelete() for bulk operations without loading
entities.

**🔹 LINQ (Language Integrated Query)**

**What is LINQ?** → Language Integrated Query:
uniform syntax to query different data sources (objects, databases, XML).

**LINQ Syntax Types?** → Method Syntax:
collection.Where(x => x.Age > 18), Query Syntax: from x in collection
where x.Age > 18.

**Deferred vs Immediate Execution?** → Deferred:
Query executes when enumerated (.Where), Immediate: Executes immediately
(.ToList(), .Count()).

**IEnumerable vs IQueryable in LINQ?** →
IEnumerable: In-memory (LINQ to Objects), IQueryable: External data sources
with expression trees.

**Select vs SelectMany?** → Select: 1-to-1 mapping,
SelectMany: Flattens nested collections (1-to-many).

**Where vs First vs Single?** → Where: Filters
collection, First: Gets first element, Single: Gets only element (exception if
0 or >1).

**Any() vs All() vs Contains()?** → Any: At least
one matches condition, All: Every element matches, Contains: Specific value
exists.

**GroupBy vs OrderBy?** → GroupBy: Groups elements
by key, OrderBy: Sorts elements by property.

**Join vs GroupJoin?** → Join: Inner join (matching
records), GroupJoin: Left join with grouped results.

**Skip vs Take?** → Skip: Bypass first N elements,
Take: Get first N elements (used for pagination).

**Aggregate Functions?** → Sum(), Count(),
Average(), Min(), Max(), Aggregate() for custom operations.

**Expression Trees?** → Represent code as data
structure, used by IQueryable providers to translate to SQL.

**Let keyword in LINQ?** → Introduces range
variable for reusing computed values in query expressions.

**Anonymous Types in LINQ?** → Compiler-generated
types for selecting subset of properties: new { Name, Age }.

**Func vs Action vs Predicate?** → Func: Returns
value, Action: No return (void), Predicate: Returns bool.

**PLINQ (Parallel LINQ)?** → Executes LINQ queries
in parallel using .AsParallel() for better performance on multi-core.

**LINQ Performance Tips?** → Use IQueryable for
databases, avoid ToList() early, use Any() instead of Count() > 0.

**DefaultIfEmpty()?** → Returns default value if
sequence is empty, useful for left outer joins.

**Zip() function?** → Combines two sequences
element by element: seq1.Zip(seq2, (a,b) => a + b).

**Union vs Concat vs Intersect vs Except?** →
Union: Unique combined elements, Concat: All elements, Intersect: Common
elements, Except: Elements in first but not second.

**Custom LINQ Extension Methods?** → Create static
methods with 'this' parameter: public static IEnumerable<T>
CustomWhere<T>(this IEnumerable<T> source, Func<T, bool>
predicate).

**🔹 Advanced/Senior Level Questions**

**EF Core Performance Optimization?** → Use
AsNoTracking(), projection (Select), split queries, compiled queries, and
proper indexing.

**LINQ Query Optimization?** → Avoid premature
materialization, use appropriate data structures, minimize database round
trips.

**Custom LINQ Provider?** → Implement
IQueryable<T> and IQueryProvider to translate expression trees to custom
query language.

**EF Core Interceptors?** → Hook into EF operations
(connection, command, transaction) for logging, auditing, or modification.

**Memory Management in LINQ?** → Use yield return
for large datasets, dispose enumerators, avoid unnecessary ToList() calls.

**Complex LINQ Queries Performance?** → Break into
smaller queries, use appropriate joins, consider raw SQL for complex scenarios.

**EF Core Value Converters?** → Convert between
entity property types and database column types (enum to string, JSON
serialization).

**LINQ Expression Compilation?** →
Compile<TDelegate>() converts expression trees to executable delegates
for better performance.

[Encryption Decryption](https://www.notion.so/Encryption-Decryption-280ed778d3548062af0ae9317270a7d0?pvs=21)

[Scoped/Session Scenario+Short explanation](https://www.notion.so/Scoped-Session-Scenario-Short-explanation-280ed778d354805e800ce833b06263bf?pvs=21)

[Middleware](https://www.notion.so/Middleware-280ed778d354804aabf7e9e04c1f57ca?pvs=21)

[Ref/Out](https://www.notion.so/Ref-Out-281ed778d354806bb8e0eb326d57dad0?pvs=21)

[Class/Object](https://www.notion.so/Class-Object-281ed778d35480998ea4f4ad29b5146d?pvs=21)

[**Same method in 2 interfaces -(Explicit Interface Implementation )**](https://www.notion.so/Same-method-in-2-interfaces-Explicit-Interface-Implementation-281ed778d354804ba75aeb297fc2ff0e?pvs=21)

[Overloading examples](https://www.notion.so/Overloading-examples-281ed778d35480fba639c5530a6bcb19?pvs=21)

[Overloading + Virtual](https://www.notion.so/Overloading-Virtual-282ed778d35480b98285d11eeb80b05e?pvs=21)

[Multiple Inheritance](https://www.notion.so/Multiple-Inheritance-282ed778d3548015ba25c3a73a45e895?pvs=21)

[🔥 Set of Complex Interview Q&A (with Examples)](https://www.notion.so/Set-of-Complex-Interview-Q-A-with-Examples-282ed778d35480d8babed50a6f5ff99e?pvs=21)

[📝 C# Interfaces & Abstraction – Interview Cheat Sheet](https://www.notion.so/C-Interfaces-Abstraction-Interview-Cheat-Sheet-282ed778d35480f48215e0bfe29a914c?pvs=21)

[Angular - Canload(RouteGuard)](https://www.notion.so/Angular-Canload-RouteGuard-285ed778d35480ac8599ec19ce48818f?pvs=21)

[Index kaha lagana hai](https://www.notion.so/Index-kaha-lagana-hai-28ced778d354803abb90fb267871e12f?pvs=21)

[SQL Q&A formatted](https://www.notion.so/SQL-Q-A-formatted-28eed778d354806196f6ebe1ec6f015e?pvs=21)

[JWT Token & Security](https://www.notion.so/JWT-Token-Security-28eed778d35480e8ac04dfb50ab5d75d?pvs=21)

### 🔸 Steps to Create JWT Token in MVC

1. Install **`Microsoft.AspNetCore.Authentication.JwtBearer`**.
2. Choose algorithm (e.g., **HMACSHA256**).
3. Create claims.
4. Generate token using algorithm + claims + secret.

[Logical Q&A](https://www.notion.so/Logical-Q-A-292ed778d3548061b2dde03fcd8c3280?pvs=21)

[LINQ Q&A](https://www.notion.so/LINQ-Q-A-292ed778d354809da843d1fc43169ffd?pvs=21)

[5 to 6 year exp interview](https://www.notion.so/5-to-6-year-exp-interview-292ed778d35480dd936ccc786275109e?pvs=21)

[JS Fundamentals for MVC
](https://www.notion.so/JS-Fundamentals-for-MVC-292ed778d35480d7be2dc473b56c14fd?pvs=21)
