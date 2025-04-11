using Algoritmer_Labb_1;

// Testar alla algoritmer med växande input
for (long i = 100; i < 100000000; i*=2)
{
    NumberCounter.TestFindDuplicates(5, i);
}

for (long i = 100; i < 102500; i*=2)
{
    CalculateMaxSum.TestMaxSumAlgorithmV1(i);
}

for (long i = 100; i < 100000000; i*=2)
{
    CalculateMaxSum.TestMaxSumAlgorithmV2(i);
}

