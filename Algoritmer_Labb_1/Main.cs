using Algoritmer_Labb_1;

for (int i = 100; i < 1000000000; i*=10)
{
    NumberCounter.TestFindDuplicates(5, i);
}

for (int i = 100; i < 1000000; i*=10)
{
    CalculateMaxSum.TestMaxSumAlgorithmV1(i);
}

for (int i = 100; i < 1000000; i*=10)
{
    CalculateMaxSum.TestMaxSumAlgorithmV2(i);
}

