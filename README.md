All cheat sheet are taken from here - https://www.youtube.com/watch?v=cpuRbnWEPio&t=3731s (great resource)

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
