function twoSum(nums: number[], target: number): number[] {
     const map = new Map<number, number>(); // Map<number, index>

    for (let i = 0; i < nums.length; i++) {
        const complement = target - nums[i];

        if (map.has(complement)) {
            return [map.get(complement)!, i]; // '!' ensures not null
        }

        map.set(nums[i], i);
    }

    throw new Error("No solution found");
};