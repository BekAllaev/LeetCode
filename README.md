All cheat sheet are taken from here - https://www.youtube.com/watch?v=cpuRbnWEPio&t=3731s (great resource)

This resource - https://www.youtube.com/watch?v=Y4fGaBT45IM, suggested to not go down deep in the task from the sections below(look to the image below) (let's just left it here for info, we will see if that works or not)

<img width="500" height="245" alt="image" src="https://github.com/user-attachments/assets/03ca7293-bc90-456d-84c4-4426925ad884" />


# Two pointers
## Moving from both ends
***Examples task***  
**Problem** - *For given sorted array, find two numbers that give the target as the sum*  
<img width="903" height="469" alt="image" src="https://github.com/user-attachments/assets/bc16c444-86cc-492a-91f9-4b6a68f8b342" />

**Idea** - *Create two pointers on both ends. Sum of value from this pointers should be equal to target. Move the ***right one*** to the left if sum of two pointers is bigger than the targer, move the ***left one*** to the right if sum of two pointer is smaller than the target*

**Pseudocode**
<img width="1006" height="321" alt="image" src="https://github.com/user-attachments/assets/98ac77fc-14f7-4f1e-98c6-b12669f3054d" />
**Main ideas:**
- Initialize left and right pointers
- Move while left pointer < right pointer
- Logic of moving the pointers

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***
- Sorted array is given
- Palindrom check
- You need to find answer by narrowing the area

## Pointer per array
***Example task***  
**Problem** - *Find common elemnts from both array*
<img width="806" height="291" alt="image" src="https://github.com/user-attachments/assets/0e1ac1a7-76c7-48d9-a051-76cb3c42c22f" />

**Idea** - *Assign one pointer for one array. We keep comparing two pointer and move the one that is smaller. If pointers are equal we move item to the result and move both pointers. We stop when either of pointer is out of the array*

**Pseudocode**  
<img width="649" height="211" alt="image" src="https://github.com/user-attachments/assets/08b6a979-fdcf-4ee3-822b-cce643101100" />

**Main ideas**
- Initialize pointer per array
- Cycle untill pointers are in the array
- Logic for moving the pointers(key point)

**Time complexity - O(n+m)**  
**Space complexity - O(min(n,m))**

***When to use?***
- Several arrays are given
- You need to find union/intersection etc. of these two arrays

## Slow & Fast
***Example task***  
**Problem** - *Move all the 0 to the end(to the right part) of the array. Do it in-place*
<img width="567" height="196" alt="image" src="https://github.com/user-attachments/assets/41658b51-dff7-4ed6-af06-6e615a645d87" />

**Idea** - *Assign **slow** and **fast** pointers to the begining. Move **fast** pointer and substitute it with **slow** pointer, then move **slow** pointer one item further*

**Pseudocode**  
<img width="508" height="207" alt="image" src="https://github.com/user-attachments/assets/b71cf24a-de23-49a8-afbb-f49f4e590d71" />

**Main ideas**
- Initialize **slow** and **fast** pointers
- Cycle while **fast** pointer is in the array
- Logic of moving pointers. **Fast** pointer is moving always, **slow** pointer moves only by condition

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***
- "In-place" task is given
- Original order should be preserved

## Hint
More then one array is given => Pointer per array, else if in-place modifications => Slow & Fast, else => Moving from both ends
  
# Sliding window
## Fixed size window
***Example task***  
**Problem** - *Find maximum of **k** in-row elements*  
<img width="605" height="207" alt="image" src="https://github.com/user-attachments/assets/c18f1771-b68e-4ad2-93d0-f685ba79a4ca" />

**Idea** - *We keep moving the fixed length window until it reaches the end of the array. Meanwhile keep updating sum of the elements after each move. If sum of current window is bigger than the current max, then update current max*

**Pseudocode**  
<img width="634" height="260" alt="image" src="https://github.com/user-attachments/assets/7ea4fbb0-371b-4194-b762-90122a514ce7" />

**Main ideas**
- Initialization (for example counting the sum of the first window, as in the task above)
- Cycle while window doesn't hit the end
- Loging of moving the window

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***
- Given the fixed size of the window
- We should work with "in-row" elements

## Non-intersecting windows
***Example task***  
**Problem** - *Given the sorted array, we should find sequence of number where next one is bigger than previou one by 1*
<img width="603" height="185" alt="image" src="https://github.com/user-attachments/assets/b2a6f317-b6a8-48be-8f09-cc247f84d447" />

**Idea** - *We set two pointers to the initial element. Keep moving the right one until we don't find elemnt that is bigger than preivous one by more then 1. When this happens, we write down sequence and move left pointer to the next element(now right and left points to the same element) and we repeat the process until left pointer doesn't leave the array*
> Here are several windows, that are not intersecting

**Pseudocode**  
<img width="899" height="549" alt="image" src="https://github.com/user-attachments/assets/29b90a7c-daf3-40b8-bfc8-d9a7eac5fd68" />

**Main ideas**  
- Initialization of left and right pointers
- Cycling while left pointer is in the array
- Keep expanding(moving right pointer) the window. Here we need to find the index of the right end of the window. In other words here should be written logic for finding the boundaries of the window (Main part of the algorithm)
- Do the required job with window
- Update left and right pointer to point to the same elemnt of the next window

**Time complexity - O(n), even though we have two cycles here, it is O(n). Indeed it is O(2n) but we can omit constants in O(n). Left and right pointer keep moving forward which means we don't start from the beggining for each run of the upper loop**  
**Space complexity - O(n), since in worst case we can return array that will contain all the elments from initial array. O(1) is for extra space(for left and right pointers)**

***When to use?***
- Working with "in-row" groups
- Groups are not intersecting. One element lives in one group only

## Intersecting windows
***Example task***  
**Problem** - *Given array of 1's and 0's, also **k** is given. **K** is allowed number of substitutions of 0's. Find the longest sequence of 1's, taking into account that you can do **K** substituitons*  
<img width="534" height="156" alt="image" src="https://github.com/user-attachments/assets/1543c545-972b-45be-a4ac-6edd05100998" />

**Idea** - *We set two pointers. Left one to the start element, right one to the -1. Also setting zerosCount variable, which reperesents number of 0's in the window. If next element is 1 then move the right pointer, else move only if zerosCount<**K** and increment zerosCount. Once zerosCount and **K** are equal we write down current maximum length of the window, move the left pointer by one and update zerosCount(when left pointer meets the 0 we decrease zerosCount). Right pointer stops at the end of the array. Keep going until left pointer doesn't leave the array*

**Pseudocode**  
<img width="895" height="553" alt="image" src="https://github.com/user-attachments/assets/9226bedf-9b95-47ad-9e46-41bb045ee7d2" />

**Main ideas**
- Initialization. Left to start element. Right to -1
- Initilaliztion of initial state of the window, for example in the problem above it is zerosCount, which is equal to 0
- Cycling until left pointer doesn't leave the array
- Keep expanding(moving right pointer) the window. Here we need to find the index of the right end of the window. In other words here should be written logic for finding the boundaries of the window (Main part of the algorithm)
- Do the required job with window(in this current case calculate the length of the current window)
- Narrow the window from the left, don't forget to update the state(in this case decrement zerosCount)

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***
- Working with "in-row" groups
- Groups are intersecting. One element can live in several groups

## Hint
Fixed size window is given => Fix length window, else if groups are intersecting => Intersecting windows, else if groups are not intersecting => Non-intersecting windows

# Hash-tables
## Method of counting
***Example task***  
**Problem** - *Is given string palindrom?*
<img width="870" height="284" alt="image" src="https://github.com/user-attachments/assets/e1180a51-7096-4ec6-b33f-28e091ec93f0" />

**Idea** - *First of all, properties of palindrome - every character has even number of appearances or at least one character has odd number of appearences.*

**Pseudocode**  
<img width="592" height="214" alt="image" src="https://github.com/user-attachments/assets/21ca3f6c-f885-4994-b849-728dcc14c5a6" />

**Main ideas**
- Do the counting (in case of example task we count number of appearences of each character)
- Work with result of "Counting" phase (in case of example task we check if at least one character has odd number of appearences)

**Time complexity - O(n)**  
**Space complexity - O(k), where "k" is number of unique items in hash**

***When to use?***
- Task on anagrams or palindroms 
- Work with frequences of items' appearence

## KV - VK
***Example task***  
**Problem** - *Sort characters of the given string by the frequence of theirs appearance*  
<img width="449" height="281" alt="image" src="https://github.com/user-attachments/assets/a3af3050-aee0-4fd7-982a-008716c50d3d" />

**Idea** - *Count appreance of each character(like in example task from "Method of counting"). Create **freq_list** where index of the character is number of character's appearance. Then we build result string using **freq_list***  

**Pseudocode**  
<img width="670" height="265" alt="image" src="https://github.com/user-attachments/assets/c1d4e51e-52bf-45e6-8b88-384a537d4666" />

**Main ideas**
- Do the counting (in case of example task we count number of appearences of each character)
- Create ***freq_list*** (read **Idead** once again)
- Build result

**Time complexity - O(n)**  
**Space complexity - O(n)**

***When to use?***
- Sorting tasks
- Find top K elements that meets some condition

## Hint
Sort by frequence of appearance or top K => KV-VK, else if anagrama or palindrome => Method of counting, else => think what can be key and what can be value(look at the image below)  
<img width="545" height="301" alt="image" src="https://github.com/user-attachments/assets/dd4ed0b2-2507-4157-b460-230e4a7b6438" />

# Array & Sorting
***Problem visualisation***  
<img width="975" height="555" alt="image" src="https://github.com/user-attachments/assets/030c7629-45f1-4e70-b6ec-dbcd0f3b64b0" />  
**Description** - Several segments given. In code they are represented as arrays

***Intersection check rule***  
<img width="530" height="251" alt="image" src="https://github.com/user-attachments/assets/2eb7a667-70e9-4427-a7be-783c68a30b47" />  
**Idea** - starting coordinate of intersection is maximum coordinate of two starting points of two segments, ending coordinate of intersection is minimum of two ending coordinates of segments.

***Union of segments***  
<img width="883" height="549" alt="image" src="https://github.com/user-attachments/assets/5f4aa505-b94e-465f-9f30-91e2c1723f74" />

## Method of segments  
***Example task***  
**Problem** - *Given array of segments. Make union of all intersected segments*
<img width="711" height="310" alt="image" src="https://github.com/user-attachments/assets/718499fb-dedc-4266-9094-5de65a7b6ea4" />  

**Idea** - *First of all sort segements by theirs starting point. Add first one to the result. If next segment intersects last one, add end of this new segment to the last one. Otherwise add it as whole*

**Result**  
<img width="1212" height="585" alt="image" src="https://github.com/user-attachments/assets/15211821-c37e-4be9-b647-01cc31204816" />

**Pseudocode**  
<img width="638" height="245" alt="image" src="https://github.com/user-attachments/assets/51c55b20-8e49-4630-9db4-e6514ad874e8" />

**Main idea**
- Sorting
- Initialization
- Iterate over other segments

**Time complexity - O(n*log(n))**  
**Space complexity - O(n)**

***When to use?***
- Tasks for union or intersections

## Pointer per array, but for segments
***Example task***
**Problem** - *Given two arrays with sorted segments. Find all intersections*  
<img width="751" height="251" alt="image" src="https://github.com/user-attachments/assets/5bc18e0f-fa50-45b0-87c0-881e8613e53e" />

**Idea** - *Set pointer per array. Move pointer which points to the segment, which has lower end cordinate, if segments intersecting, write down the segments. Move untill at least one pointer is out of the range of any array*

**Pseudocode**  
<img width="698" height="208" alt="image" src="https://github.com/user-attachments/assets/806b2f32-221e-463d-b441-3fc2a30727e2" />  

**Main ideas**  
- Initialization
- Cyclus until one of the pointer leaves the range
- Logic of moving the pointers (Main idea is here. Understand when to move pointers)

**Time complexity - O(n+m)**  
**Space complexity - O(max(n,m))**

> Overall this approach is the same as - Two pointers -> Pointers per array

***When to use?***
- Sequence of intervals in several arrays

## Method of points
***Example task***  
**Problem** - *Find max number of rooms in order to make all these meetings*  
<img width="970" height="570" alt="image" src="https://github.com/user-attachments/assets/0f6a5302-26be-4567-9a45-588a30aab48c" />

**Idea** - *Each segment has start and end point. Each segment is transformed into two point, where start point has +1 as pair and end point has -1 as pair. Then we sort them by point and iterate through the pairs and incrementing/decrementing the counter. Max value of the counter is our result*

**Deatails**  
<img width="417" height="147" alt="image" src="https://github.com/user-attachments/assets/2a16dc19-64ae-416a-bb26-3b5d0348822d" />

<img width="673" height="221" alt="image" src="https://github.com/user-attachments/assets/e2089f88-2f5d-4920-a189-0ccfd9692394" />

**Pseudocode**  
<img width="896" height="502" alt="image" src="https://github.com/user-attachments/assets/93f9274b-8c71-4749-811f-3dfca98e13f5" />

**Main ideas**  
- Convert to points
- Sorting
- Iterate through sorted points and form the answer (Key point is here. Form the result correctly)

**Time complexity - O(n*log(n))**  
**Space complexity - O(n)**

***When to use?***  
- Find maximum number of simoultaneous events

## Hints
Two arrays of segments are given => Pointer per array, else if Find maximum number of parallel/simoultaneous events at some point of time => Method of points, else => Method of segments

# Binary search
## Base binary search
***Example task***  
**Problem** - *Find last appearance of number 8. Sorted array is given*    
<img width="590" height="173" alt="image" src="https://github.com/user-attachments/assets/61a241d6-c7b5-4bd9-ae6f-8aa9784668b9" />

**Idea** - *Set pointers from both end. Compare middle element to target(which is 8). If middle elemnt is bigger than target than move right pointer to the middle element, else move left pointer to the right. Continue untill two pointer are stand by each other(i.e. they are neighbours)*

**Idea #2** - *We have "bad" and "good" elements, where "bad" elements are ones that are bigger than the target and "good" elements are smaller or equal to the target. So we need to find the element where "bad" switches to "good". The border lies between last "good" pointer and first "bad" pointer*

***Details***  
<img width="923" height="514" alt="image" src="https://github.com/user-attachments/assets/a8774262-d79c-46f9-8d88-e57f0ac1797d" />

***Main ideas***  
- Initialization of left and right pointers
- Cycle until left and right don't stand by each other(neighbours)
- Finding the "middle"
- Narrowing down search area
- Handling the result

***Main ideas #2*** - *find out function that define if element is "good", this is the core idea. Usually Left and Right pointer are not needed here, using element from the array and target is enough*

***Main ideas #3*** - *once again, we are looking for last "good" and first "bad"*

**Time complexity - O(log(n))**  
**Space complexity - O(1)**

***When to use?***  
- If we can separate items into "good" and "bad"
## Double binary search
***Example task***  
**Problem** - *Find first and last position of the 7, if not exists return [-1,-1]*  
<img width="451" height="171" alt="image" src="https://github.com/user-attachments/assets/2ba75161-c059-416c-9b46-9444c5ee08af" />

**Idea** - *run two binary searchs. First one will find last position, second one will find first position*

**Pseudocode**  
<img width="831" height="639" alt="image" src="https://github.com/user-attachments/assets/e9dcdeec-ab25-4f71-a599-66888d7baae4" />

**Time complexity - O(log(n))**  
**Space complexity - O(1)**

***When to use?***
- Find the range
- We need to run first binary search in order to prepare array for the main run of the binary search

## Hint
If we can separate items on "good" and "bad" then => Base binary search, else if some preparation is needed => Double binary search

# Stack
## Basic stack 
***Example task***  
**Problem** - *Check that parenthesis are in the correct order*  
<img width="574" height="264" alt="image" src="https://github.com/user-attachments/assets/eaf5bd19-35d8-4c61-aea8-b1754380bb78" />

**Idea** - *Put parenthesis into stack if it is opening and pop if it is closing parenthesis and it matches top openning. At the end check if stack is empty, if yes, then parenthesis were in correct order. If current closing and current top opening parenthesises do not match we return false*

**Pseudocode**  
<img width="531" height="239" alt="image" src="https://github.com/user-attachments/assets/f996b830-2e97-4c70-97cf-73b5902634a5" />

**Main ideas**  
- Initialize stack
- Cycle
- Logic of working with stack

**Time complexity - O(n)**  
**Space complexity - O(n)**

***When to use?!***  
- We need to work with parenthesis or nested structures(like if sequence of parenthesis is correct)
- Compute some expression
- We work with some intermidiate state

## Monothonic stack
***Example task***  
**Problem** - *Given array with numbers. Convert this given array into array, where for each element we find next bigger element from the right side, if there is no such for current element we write down -1*  
<img width="408" height="169" alt="image" src="https://github.com/user-attachments/assets/e90387b4-3056-4b21-974b-4c0ad12bd8bc" />

**Idea** - *First we initialize array of -1's, size of this array is equal to the size of given array. We starting from the end(in other words we starting from the right) and put element on the stack. When we want to push item to stack we compare it with the top item of the stack, if the item that we want to push is smaller than the top item from the top of the stack we write top item from the stack into result array and push the new item. If the item that we want to push is bigger than the top item from the stack then we pop top item then we compare the item that we want to push with new top as we did above.*

**Idea 2**  
<img width="749" height="359" alt="image" src="https://github.com/user-attachments/assets/7ecc8be7-edd9-463c-bcac-cace9cd338f5" />
We can see that on each step items in the stack are descending from top to bottom, that is why it is called monothonic stack. We have monothinic sequences stored in stack

**Pseudocode**  
<img width="645" height="263" alt="image" src="https://github.com/user-attachments/assets/3f4ea3fd-0474-46bb-84d1-03a36a9a40be" />

**Main ideas**  
- Initializations
- Cycle
- Logic of keeping the monotone
Key ideas: Find out if we should move from left to the right or from right to the left, and find out logic that will keep stack monotone

**Time complexity - O(n), even though we can have several cycles it is still O(n), since every item is pushed and poped only once**  
**Space complexity - O(n)**

***When to use?***  
- Find the closest bigger/smaller item from the left/right

 ## Pseudo stack
 ***Example task***   
 **Problem** - *Given sequence of same type of paranthesis, we should find out if this sequence is correct or not*  
 <img width="420" height="216" alt="image" src="https://github.com/user-attachments/assets/b288c3ad-7f12-4a9f-93e0-94696969d107" />

 **Idea** - *We use counter which we increment when we read opening parenthesis and decrement when we read closing parenthesis. At the end check if counter is equal to zero*

**Pseudocode**  
<img width="595" height="251" alt="image" src="https://github.com/user-attachments/assets/bcba66fe-3dcd-41f2-9b36-275865a41093" />

**Main ideas**
- Counter intialization
- Cycle
- Logic of counter increment/decrement

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***  
- We have a sequence where we have items of the same type
- We need to know only the size of the stack and not its content

## Hint
We need to find closest smaller/bigger item => Monothonic stack, else if we can replace stack with counter => Pseudo stack, else => Basic stack

# Prefix sums

***Definition of prefix sums***  
Let's say some array is given. Based on this given array we create another one, where first elemnt is 0 always. Let's say we want to add new element, we don't this element itself, rather we add this element to the current last element and thus get the new element(see the picture below)  
<img width="592" height="171" alt="image" src="https://github.com/user-attachments/assets/e9026677-d268-4958-87ad-727c28a2ea6a" />

***Facts***  
- Element in the prefix sum array with N index is the sum of all previous elements from the original array, thus we have sum of all N elements for O(1)

***What is sufix sums?***  
The same concept but from the end(from the right side of the array)

## Array of sum
***Example task*** 
**Problem** - *Two dimension array is given. Find position of the rook(can move only to sides and forward and backward) where fields that are attacked by rook give maximum sum*  
<img width="533" height="466" alt="image" src="https://github.com/user-attachments/assets/282571b7-3d5b-42e6-a45c-7109381b3d28" />

***Idea***  
<img width="428" height="298" alt="image" src="https://github.com/user-attachments/assets/40ae1574-6516-481e-ba83-f69b9c85963d" />  
*Calculate sum for each row and column, then we itterate whole array and find sum for each field, take a look to the picture below.*  
<img width="841" height="563" alt="image" src="https://github.com/user-attachments/assets/df00f75e-fd2d-465f-9f74-ba4d2b21e737" />


***Pseudocode***  
<img width="1038" height="565" alt="image" src="https://github.com/user-attachments/assets/95bc2427-aee2-4b04-8c3a-7a4f6da56e86" />

***Main ideas***  
- Initialization
- Calculating array of sums
- Finding the answer through calculated array of sums

**Time complexity - O(n*m), where N is the size of the matrix**  
**Space complexity - O(n+m)**

***When to use?***  
- Matrix is given
- We need to calculate aggregates by columns and rows

## Moving prefix
***Example task***  
**Problem** - *Array is given. Find index of the element, so elements from the right and elemenents from the left give equal sum*  

<img width="412" height="223" alt="image" src="https://github.com/user-attachments/assets/e07d255a-f19d-450e-8182-a3b8f8f0d7b7" />

**Idea** - *Calculate sum of all elements. Keep moving pointer and recalculate sum of the items from the right and from the left, untill we met the condition or reach the end of the array*

**Idea 2** - *Idea of this pattern is that instead of suffix/prefix array we use some variable(I am not sure if I understand the point.... but wrote it down here, so it reaches me later..... I hope)*

***Pseudocode***  
<img width="604" height="257" alt="image" src="https://github.com/user-attachments/assets/68291ba4-af5c-472b-b629-ab914eb67d0e" />

**Main ideas**  
- Initialization
- Cyckling 
- Logic of update (in this current case we keep updating Suffix sum and Prefix sum)

> Pattern is called "Moving prefix" since we calculate prefix and suffix in flight(we don't do it beforehand)

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***  
- We don't need to know elements of the "Prefix" and "Suffix" sums, we need only let's say - sum of suffix and prefix arrays
- Sum(that we calculate in flight) can be used as hash key for example or in other data structures

## Hint
You store prefix and order of the sum matters => classical prefix array
You store prefix and order of the sum doesn't matter => prefix as key for hash
Work with sums by rows, columns, diagonales => Array of sum
Don't Work with sums by rows, columns, diagonales => Moving prefix

# Linked list
## Basic operations
### Counting elements
Just iterate through the nodes and increase the counter  
<img width="425" height="224" alt="image" src="https://github.com/user-attachments/assets/0fbb2324-5ee8-4ae1-93f2-94fc1bc7ddbb" />

**Time complexity - O(n)**  
**Space complexity - O(1)**

### Finding the middle of the list
For even number of elements we usually from two middle we usually take the first one, for odd number of elements it is just the middle one  
<img width="529" height="252" alt="image" src="https://github.com/user-attachments/assets/d8d4807d-189d-4bc9-b935-4432c5901b2d" />

**How we find the middle?**  
~~We iterate over the list and divide the size by 2.~~

We set "slow" and "fast" pointers, where slow moves by one and fast moves by two elements. When fast pointer reaches the end, the slow one points to the middle  
<img width="472" height="232" alt="image" src="https://github.com/user-attachments/assets/7ff64538-297e-4c2c-bf31-117f7ea8aee0" />

**Time complexity - O(n)**  
**Space complexity - O(1)**

### Reversing of the linked list
**Main idea** - **do it without creating anothe linked list**

**Idea** - *Set "prev" and "curr" pointer. Curr points to the current node and we put this curr pointer to the temp pointer, then we move to the Curr.Next and break the link between curr and curr.next, then we point tmp.next to the prev pointer, then we move prev. Move until curr is not null*

<img width="455" height="270" alt="image" src="https://github.com/user-attachments/assets/cf1917db-6d64-4a74-a942-82b7fb76837e" />

**Time complexity - O(n)**  
**Space complexity - O(1)**

---

## Dummy node
***Example task***  
**Problem** - *Merge two sorted linked list*  
<img width="752" height="507" alt="image" src="https://github.com/user-attachments/assets/ea5b14c3-2d98-4c75-b898-2c103a945c2c" />

**Idea** - *We don't create new linked list, actually we just re-arrange existing connections, we just create one dummy node*  
**Idea 2** - *We create dummy node, and set a pointer per linked list. We compare pointers and the one that is smaller is assigned to the dummy node, then we move the smaller pointer. We continue until two pointer don't leave the list. At the end we return Dummy.Next, that is the answer*  
<img width="553" height="359" alt="image" src="https://github.com/user-attachments/assets/71b51936-e00e-49c0-b642-b95d80e33e7e" />

**Pseudocode**  
<img width="516" height="238" alt="image" src="https://github.com/user-attachments/assets/811799d6-09c5-4646-99a1-a097518549c1" />

> If programming language don't have Garbage Collector(like C++ does) don't forget to delete Dummy Node

**Main ideas**  
- Initialize dummy node
- Calculate the answer
- Return Dummy.Next

**Time complexity - O(n+m)**  
**Space complexity - O(1)**

***When to use?***  
- We need dummy node to bind answer to it(like we need it temporarly)
- Do deletion of some nodes without "if-else" (I am not sure if I understand this)

## Partial reverse
***Example task***  
**Problem** - *Is given linked list pallindrome?*  
<img width="570" height="211" alt="image" src="https://github.com/user-attachments/assets/adb8ee55-a351-4f2f-bf1a-4e91b2e87342" />

**Possible idea** - *Use pattern "moving from both end" like we would do for array but it doesn't work here since in linked list we can move only forward*

**Working idea** - *Find the middle and reverse only the one middle of the list, where middle.next will point to the null node. At the end we just iterate from both sides and if all elements are equal then we have a pallindrome*  

***Pseudocode***  
<img width="596" height="269" alt="image" src="https://github.com/user-attachments/assets/380ca2af-1a9f-417c-b987-857979e55c19" />

**Main ideas**  
- Use "Finding the middle" algorithm
- Use "Reverse the linked list" algorithm
- Then "Partial reverse"
- And some other pattern (for example in this current case it was - "moving from both sides")

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***  
- Task with pallindrome
- We need to use pattern "from both sides" in linked list

## Hint
We need to create new list from given nodes => Dummy node, else we need to work "from both sides" => partial reverse
**Main idea of the stack** - *Most of all we need stack operations in order to prepare data for application of the main algorithm*

# Backtracking problems
## Brute force
***Example task***  
**Problem** - *Generate all possible string combinations*  
<img width="1047" height="474" alt="image" src="https://github.com/user-attachments/assets/73759004-81bc-4202-b517-2dd5cebe0a17" />

**Idea** - *First of all we we add empty string(I am not sure why), then we add all characters from 2 and remove empty string(still not sure why). Then for every character from 2 we combinate with characters from 4 at the end we remove character from 2.*  
<img width="518" height="300" alt="image" src="https://github.com/user-attachments/assets/6fc787b2-b78b-4bd2-a775-f0695ee2ffe6" />

***Pseudocode***  
<img width="637" height="309" alt="image" src="https://github.com/user-attachments/assets/3067adeb-af13-4362-860a-af06a99f6e0f" />

***Main ideas***  
- Initializing of queue/dequeue
- Cyckling(here is the main idea, we need to understand condition of stopage)
- Removing first element
- Generation of the combination

**Time complexity - O(n*4^n)**  
**Space complexity - O(n*4^n), FUHA, I am not sure what does it mean and if this is optimal for all bruteforce approaches. More likely it is only for current problem**

***When to use?!***  
- Generating all possible combinations, replacements or sub-sets

## Backtracking
***Example task***  
**Problem** - *Given N. We need to find all possible combinations of sequence with valid set of parenthesis*  
<img width="654" height="205" alt="image" src="https://github.com/user-attachments/assets/21ef5ac3-7735-4981-93e8-f1bee844dfa3" />

**Idea** - *From the start we generate only valid sequence. We don't generate all and then remove not valid*

**Idea 1** - *We start from this. We put empty string. First number is number of openning parenthesis, second number is clossing parenthesis.*  
<img width="595" height="169" alt="image" src="https://github.com/user-attachments/assets/b9ae074f-2b49-4049-87e6-4382b45802ce" />

**Idea 2** - *So at each step we work with first element. We can append closing parenthesis when number of openning parenthesis is bigger then number of closing parenthesis. After each iteration we remove first element. We stop as soons as first element has 2n chars*

***Pseudocode***  
<img width="676" height="260" alt="image" src="https://github.com/user-attachments/assets/c2b79665-f1c0-407f-89f0-6ffeadf9b2de" />

***Main ideas***  
- Initializing queue/dequeue
- Cyckling(here is the main idea, we need to understand condition of stopage)
- Removing first element
- Generation of the valid-only combination

**Time complexity - O(n*4^n/sqrt(n))**  
**Space complexity - O(n*4^n/sqrt(n)), FUHA, I am not sure what does it mean and if this is optimal for all bruteforce approaches. More likely it is only for current problem**

> In backtracking time/space complexities are solely based on Math, so maybe there is the next thing that you should improve....

Author suggest to say this Time/Space complexity on interview - O(n*2^(2*n)), he says this is overall number of combinations
Author also suggest that you explain on interview that - we are going to generate only correct sequence and we only say overall number of combinations

***When to use?!***  
- We need to generate sequence by some condition

## Hint
We need optimized combination => Backtracking, else => Brute force

# Tree
## Little reminder
- Every node has only one parent

## Basic errors
- Null check of the children, rather check the node itself  
<img width="601" height="231" alt="image" src="https://github.com/user-attachments/assets/24235683-4fbb-4798-bfc0-27e4f53d0a69" />

- Forget to handle base case - node is null
<img width="625" height="180" alt="image" src="https://github.com/user-attachments/assets/bab7f650-0c2a-4a6e-9669-62d27ae30189" />

## From bottom to top
***Example task***  
**Problem** - *Find the longest path*  
<img width="443" height="401" alt="image" src="https://github.com/user-attachments/assets/5e287ee4-e96c-42fa-948b-d563aea4bd4c" />

**Idea** - *We start from finding the path from the leafs*  

**Pseudocode**  
<img width="1108" height="541" alt="image" src="https://github.com/user-attachments/assets/d5323bf6-910a-4ca7-acfb-0881c49e72a2" />

***Main ideas***  
- Handling base case(in this situation - null node)
- Traverse sub-trees
- Update the result (first main point is here - understand how and what to update)
- Return result upward to the parent (second main point is here - understand what to return upward)

**Time complexity - O(n), we read every node one time**  
**Space complexity - O(h), where h - is the height of the tree**

***When to use?***  
- We need to calculate the final result from bottom to up
- Result of every node depends on the result of children nodes

## From top to bottom
***Example task***  
**Problem** - *The tree is given. If exist path from root to leaf which sum gives targetSum?*  
<img width="676" height="630" alt="image" src="https://github.com/user-attachments/assets/aada695e-f3ff-4611-b802-1919343be30b" />

**Idea** - *We start from root and add value of the root node to the current sum. Use recursion we go down to the children and keep passing "current sum"+"current node's value". If we are on the leaf we check if current sum is equal to the target sum, if yes then we return upward - true*

***Pseudocode***  
<img width="649" height="269" alt="image" src="https://github.com/user-attachments/assets/770ca1ff-018a-4945-819b-e4d342e27671" />

**Main ideas**  
- Base case
- Recursive traversal to the bottom
- Handling the result

**Key** - *understand what to pass to the child from the parent and how recursion occurs*

**Time complexity - O(n), we read every node one time**  
**Space complexity - O(h), where h - is the height of the tree**

## Hint
If we calculate answer from leafs to root => from bottom to top, else => from top to bottom, else ask 4 questions:
- What is the base case of recursion?
- What we do before traversing right/left sub-tree?
- How to handle the result?
- What we should return back to parent? 

# Graphs
## Theory re-cap
**Oriented graph** - *graph where edges have directions, we can move only following directions*  
**Not-oriented graph** - *grpah where edged don't have directions, we can move in both direction on the edge*  
<img width="704" height="299" alt="image" src="https://github.com/user-attachments/assets/9fb8baa3-e0ec-4309-b5a2-8409c5757c77" />

**Component** - *is the cycle of the several nodes*  
<img width="1295" height="553" alt="image" src="https://github.com/user-attachments/assets/019980c0-b556-4997-823c-de03c9488a66" />

**How to set edges?**  
<img width="431" height="692" alt="image" src="https://github.com/user-attachments/assets/916d455c-24b2-4238-ade8-87aed2b665a1" />  
Edges are set by the hash-set where key is the edge and value is array of neighbour edges

**Build the graph from the given edges array**  
<img width="661" height="345" alt="image" src="https://github.com/user-attachments/assets/6df10b86-2b89-4308-a98d-e07ee15eea8f" />

**Fro not-oriented graph we add connection for both end of the edge. Look to the code below**  
<img width="648" height="192" alt="image" src="https://github.com/user-attachments/assets/c1d58a96-ae89-4cec-add9-62017d85f266" />

**Otherwise add just for one node**  
<img width="709" height="168" alt="image" src="https://github.com/user-attachments/assets/72ce1c60-9f60-46cc-a96d-f2b2a2e9584b" />

## Breadth-first-search
***Example task***  
**Problem** - *Find the shortest path from 5 to 1*  
<img width="498" height="249" alt="image" src="https://github.com/user-attachments/assets/15426ce4-91e2-4ae8-be6a-db3fba8d26d3" />

**Idea** - *We initialize the queue and put in there initial node(in queue we store the value of the node and distance between the node and initial node), next we set hash-set - visited, where we put visited nodes. We take the first element from queue and look to its neighbours, then we add each neighbour and calculate its distance from initial node, also we put this node into visitide hash-set. We stop untill we are on the target element.* 

**Idea 1** - *We take first element from the queue and we work with it. We add its children, we calculate distance by summing dist of its parent plus 1.* 

**Pseudocode**  
<img width="707" height="298" alt="image" src="https://github.com/user-attachments/assets/d73886c3-7dfb-469b-a818-4864d9df41d6" />

**Main ideas**  
- Initialization. Put initial node into the queue.
- Cyckly while queue is not empty
- Get first element, also handling base case(in this current example is - we met finish node)
- Go through every neighbour of the current node
- If neighbour node is not visited put it into the visitied hash-set

**Time complexity - O(n+m), where n is number of nodes and m is number of edges**  
**Space complexity - O(n), where n is number of nodes**

## Depth-first-search
***Example task***  
**Problem** - *Maze is given. Go from start to finish.*  
<img width="768" height="667" alt="image" src="https://github.com/user-attachments/assets/37f05155-923a-4268-a7b5-a0a5b774df42" />

**Idea of DFS** - *Algorithm chooses one branch and follows down it till the end, if target condition doesn't met it chooses another branch and follows down it too.*

**Pseudocode**  
<img width="1008" height="675" alt="image" src="https://github.com/user-attachments/assets/a014d96a-3693-4629-ac04-e45abd74b432" />

**Main ideas**  
- We initialize stack and visited hash-set with initial node
- Cyckly until stack is not empty
- Pop the element from the stack and handle it if it is the end
- Walk through all the neighbours
- Push neighbour into the stack(if it is not visited, if it is not a "wall", in other words if it meets the condition)

**Idea of DFS and BFS** - *DFS works with stack and BFS works with queue*  

**Time complexity - O(n+m), where n is number of nodes and m is number of edges**  
**Space complexity - O(n), where n is number of nodes**

## BFS vs DFS
- Big O of time and space - for both algos Big O of time/space is the same
- Actual space consumption - BFS actualy usually consump fewer space
- BFS is more universal. BFS can find the shortest path, it can traverse the graph. DFS cannot find the shortest path
- During the interview BFS is more valuable(I don't know if it is true or not)

Author mentions that I would like to consider BFS if task for minimum or shortest path kind of stuff is given

## Shortest path
***Example task***  
**Problem** - *Start and finish points are given. Find the shortest path between them.*  
<img width="663" height="272" alt="image" src="https://github.com/user-attachments/assets/a192d143-6942-47f5-8559-308f4250ac20" />

**Idea** - *We launch BFS from initial(start) point. We just need to properly think about condition of marking the node as visited.*  

**Pseudocode**  
<img width="877" height="736" alt="image" src="https://github.com/user-attachments/assets/55db1c99-f23c-4613-a622-80236c5a761d" />

**Main idea**  
- Set strating point
- Handle the node
- Traverse the neigbhours

**Time complexity - O(n*m), even though we use BFS, Big O is m*n. Because we work with matrix with deminesion m*n**  
**Space complexity - O(n*m)**

**When to use?**  
- When we need to find minimum number of nodes/edges or shortest path or recover the path

## Finding binded components
**Example task**  
**Problem** - *Find number of binded components*  
<img width="703" height="392" alt="image" src="https://github.com/user-attachments/assets/6b3e1909-e5c6-48fb-833a-bcf6c6841135" />

**Idea** - *Step on each non-visited node and from each start BFS. BFS will stop once it visits all nodes in binded component, then we will need to start BFS in another component. Number of BFS launches will be equal to number of binded components*

**Pseudocode**  
<img width="623" height="253" alt="image" src="https://github.com/user-attachments/assets/ffb6026c-297e-49de-a99b-b792d3263537" />

**Main ideas**  
- Build the graph if needed
- Create shared variables to store result of several BFS executions
- Logic of launching BFS and handling the result

**Time complexity - O(n+m)**  
**Space complexity - O(n), since we don't store info about edges**

***When to use?***  
- Find number of binded components
- Find component wich meets some condition(biggest/smallest component)

## Sequence of dependencies (consider better naming)
***Example task***  
**Problem** - *Given several tasks where each one can be completed only if previous tasks are completed*  
<img width="1280" height="593" alt="image" src="https://github.com/user-attachments/assets/4de4f375-3c30-4231-9762-39e156c6be16" />

**Idea** - *We are dealing with topological task. We will solve it using Khan's algorithm. For each task we count indegree, count of tasks that should be done so we can do current task.
So we put tasks that have indegree == 0 into the queue(very important note - we can push into the queue taks that have only 0 indegree). While queue is not empty we keep taking first element and put it into the result and not forget to solve to decrement indegree of dependent tasks. Once occur task with indegree 0 we put into the queue. At the end we compare if resulting array size is equal to the size of the given array, so we are sure that there were not cyclus*  

**Pseudocode**  
<img width="1198" height="547" alt="image" src="https://github.com/user-attachments/assets/ada189d4-9521-434a-afdf-847029b30c3b" />

**Main ideas**  
- Initialization
- BFS (important part is to correctly traverse the neighbours)
- Check if any cycles exist by comparing resulting's array size with given array's size (important part)

**Time complexity - O(n+m)**  
**Space complexity - O(n)**

***When to use?***  
- Check possible cycles in the graph
- We need topological order

## Hint
Find shortest path and edges are not weighted => BFS, find shortest path and edges are weighted => another algo  
Find cyclus or topological order => Sequence of dependencies  
Else => Finding binded components

# Dynamic programming
## One dimensional dynamic programming
***Example task***  
**Problem** - *Ladder is given. We need to find all possible combinations of way how we can reach the top of the ladder. You can step one by one or you can step up to two steps at some point and then go one by one*  
<img width="947" height="658" alt="image" src="https://github.com/user-attachments/assets/517453c4-c0bb-49b0-b390-e530055f0be5" />

**Idea** - *We set array with size of the number of steps given, every element of the array shows in how many ways we can reach this current step. Frist of all we handle several base cases - step number 0 and 1. We can reach step number 0 which is 1, since there is only way to be in step number 1 - 1. Then step number 1, for this one we will have 1 too, since there is only one way to step on to the step number 1, from 0 to 1. Then for each next step we keep summing elements of two previous steps until we go to last step number 5. Number of steps for this ladder will be the answer.*  

**Pseudocode**  
<img width="593" height="289" alt="image" src="https://github.com/user-attachments/assets/ec06ffbd-10d9-476c-aa46-b9ce56d19ae0" />

**Main ideas**  
- Initialization
- Base cases of dynamic
- Main logic of calculation all of the further results

**Time complexity - O(n)**  
**Space complexity - O(1)**

***When to use?***  
- One array is given and we need to find max/min but we cannot take all elements
- We need to find "how many ways" or "how many variants of (something)"
- Some target number is given or some nominals are given(for example how much does one step costs or something like this) and we need to find minimum number of steps (effort) to be done/taken (shit, this need to be re-thinked somehow...)
- Find the longest sub-sequence which meets some condition

## Multidemnsional dynamic programming
***Example task***  
**Problem** - *We have a bag with given capacity(let's say 6) and we have several items with weight and price given for each item. We should find combination that gives maximum value*  
<img width="543" height="231" alt="image" src="https://github.com/user-attachments/assets/349d4be8-206e-45da-8ef2-861149521d11" />

**Idea** - *So let's draw two dimensional array, where rows are items in the bag(not the exact item but the items, 2 means there are two items now in the bag) and columns are capacities of the bag. For example here element at [2,5] means the value of the first two items in the bag that has capacity 5. So how actually we calculated value for [2,5]? We take a look to the [1,5] but why? Because for bag with capacity 5 we already know that there fits item #1 (which weights 5 and gives value - 6). Can we add item two there?! No, we can't so we just add to the value from [1,5] zero, which make 6 + 0 = 6. Another way is to do combination of item #1 and item #2 but the only combination that fills the bag maximum is when there is only item #1 in the bag. Let's consider the case for [2,3]. We cannot put there item #1 since it won't fit there, so we put there only item #2. Once we put it there we left with capacity 0 and theoretically we can put there item #1. We know that value of the bag for item #1 for bag with capacity 0 lives in the [1,0], so take this value and add it to the 4(value 4 is because currently in the bag with capacity 3 is item #2)*  
<img width="567" height="403" alt="image" src="https://github.com/user-attachments/assets/eaf013a6-36c4-4249-882c-91cc4cd7eb01" />

**Final DP matrix**  
<img width="520" height="353" alt="image" src="https://github.com/user-attachments/assets/41f9ce27-2838-4b99-87b9-ecd799fad44b" />

**Pseudocode**  
<img width="736" height="257" alt="image" src="https://github.com/user-attachments/assets/d3cab97d-6ad6-4107-9671-543d2a90da4a" />

**Main ideas**  
- Initialization
- Base cases of DP
- Calculation other cases of DP

**Time complexity - O(n*w), in this current case n is the number of items and w is capacity of the bag but actually it is dimensions of the matrix**  
**Space complexity - O(w)**

***When to use?***  
- Matrix is given, we should find optimal way or count number of path
- Two strings are given. Compare or edit them
- Pick items from the given list to meet the maxmimum value of items

## Hint
- Find all possible combinations => it is NOT a DP, IT IS "Backtracking problems"
- Else if we need to remember the previous state => it is NOT a DP, another topic
- One array is given and we should find max/min or number of combinations => one dimensional DP
- Several arrays are given and we should find max/min or number of combinations => multi dimensional DP

Sneakpeak on how to determine DP problem  
<img width="513" height="392" alt="image" src="https://github.com/user-attachments/assets/7a1ecb92-0900-4510-932c-bd2db716193a" />
