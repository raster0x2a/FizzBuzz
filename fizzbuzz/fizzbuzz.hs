fb :: Int -> String
fb n
  | mod n 15 == 0 = "FizzBuzz"
  | mod n 3 == 0 = "Fizz"
  | mod n 5 == 0 = "Buzz"
  | otherwise = (show n)

rep :: Int -> IO ()
rep 1 = putStrLn (fb 1)
rep n = do
  rep (n-1)
  putStrLn (fb n)

main :: IO ()
main = rep 20
