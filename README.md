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

# Slow & Fast
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
